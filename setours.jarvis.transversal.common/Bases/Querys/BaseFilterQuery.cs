using System.Collections.Generic;

namespace setours.jarvis.transversal.common.Bases.Querys
{
    public class BaseFilterQuery
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public object Value { get; set; }
        public string Condition { get; set; }
        public IEnumerable<BaseFilterQuery> Filters { get; set; }
    }
}
