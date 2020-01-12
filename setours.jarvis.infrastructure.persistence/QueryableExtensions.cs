using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using setours.jarvis.transversal.common.Bases.Querys;

namespace setours.jarvis.infrastructure.persistence
{
    public static partial class QueryableExtensions
    {
        public static IQueryable<T> Filter<T>(this IQueryable<T> queryable, IEnumerable<BaseFilterQuery> filters)
        {
            var parameter = Expression.Parameter(typeof(T));
            BinaryExpression binaryExpression = null;
            binaryExpression = CombineFilterBinaryExpression(parameter, filters, binaryExpression);
            var expression = (Expression<Func<T, bool>>)Expression.Lambda<Func<T, bool>>(binaryExpression, parameter);
            return queryable.Where(expression);
        }

        public static IQueryable<T> Sort<T>(this IQueryable<T> queryable, IEnumerable<BaseSortQuery> sort)
        {
            var elementType = typeof(T);

            foreach (var item in sort)
            {
                var order = item.Ascending ? "OrderBy" : "OrderByDescending";
                var parameter = Expression.Parameter(elementType);
                var property = Expression.PropertyOrField(parameter, item.Field);
                var selector = Expression.Lambda(property, parameter);
                var orderByExpression = Expression.Call(typeof(Queryable), order, new[] { elementType, property.Type }, queryable.Expression, selector);
                queryable = queryable.Provider.CreateQuery<T>(orderByExpression);
            }

            return queryable;
        }

        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, int page = 1, int size = 100)
        {
            return queryable.Skip((page - 1) * size).Take(size);
        }

        public static string ToSql<TEntity>(this IQueryable<TEntity> query) where TEntity : class
        {
            var enumerator = query.Provider.Execute<IEnumerable<TEntity>>(query.Expression).GetEnumerator();
            var relationalCommandCache = enumerator.Private("_relationalCommandCache");
            var selectExpression = relationalCommandCache.Private<SelectExpression>("_selectExpression");
            var factory = relationalCommandCache.Private<IQuerySqlGeneratorFactory>("_querySqlGeneratorFactory");

            var sqlGenerator = factory.Create();
            var command = sqlGenerator.GetCommand(selectExpression);

            string sql = command.CommandText;
            return sql;
        }

        private static object Private(this object obj, string privateField) => obj?.GetType().GetField(privateField, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(obj);

        private static T Private<T>(this object obj, string privateField) => (T)obj?.GetType().GetField(privateField, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(obj);

        private static BinaryExpression CombineFilterBinaryExpression(ParameterExpression parameter, IEnumerable<BaseFilterQuery> filters, BinaryExpression binaryExpression)
        {
            foreach (var filter in filters)
            {
                if (filter.Filters != null)
                    binaryExpression = CombineFilterBinaryExpression(parameter, filter.Filters, binaryExpression);

                var prop = Expression.Property(parameter, filter.Field);
                var val = Expression.Constant(filter.Value);

                ExpressionType operador = ExpressionType.Equal;

                if (!String.IsNullOrEmpty(filter.Operator))
                {
                    switch (filter.Operator)
                    {
                        case "=":
                            operador = ExpressionType.Equal;
                            break;
                        case "!=":
                            operador = ExpressionType.NotEqual;
                            break;
                        default:
                            operador = ExpressionType.Equal;
                            break;
                    }
                }

                ExpressionType condicion = ExpressionType.AndAlso;

                if (!String.IsNullOrEmpty(filter.Condition))
                {
                    switch (filter.Condition.ToUpper())
                    {
                        case "AND":
                            condicion = ExpressionType.AndAlso;
                            break;
                        case "OR":
                            condicion = ExpressionType.OrElse;
                            break;
                        default:
                            condicion = ExpressionType.AndAlso;
                            break;
                    }
                }

                var binary = Expression.MakeBinary(operador, prop, val);
                binaryExpression = binaryExpression == null ? binary : Expression.MakeBinary(condicion, binaryExpression, binary);
            }

            return binaryExpression;
        }
    }
}
