using System.Collections.Generic;

namespace setours.jarvis.transversal.common.Bases.Querys
{
    public class BaseSearchQuery
    {
        public IEnumerable<BaseIncludeQuery> Includes { get; set; }

        public IEnumerable<BaseFilterQuery> Filters { get; set; }

        public IEnumerable<BaseSortQuery> Sort { get; set; }

        public int Page { get; set; }

        public int Size { get; set; }
    }
}
