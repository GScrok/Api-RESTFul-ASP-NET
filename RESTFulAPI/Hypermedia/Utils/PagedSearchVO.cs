using RESTFulAPI.Hypermedia.Abstract;

namespace RESTFulAPI.Hypermedia.Utils
{
    public class PagedSearchVO<T> where T : ISupportHyperMedia
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalResults { get; set; }
        public string SortedFields { get; set; }
        public string SortDirections { get; set; }
        
        public Dictionary<string, Object> Filters { get; set; }
        public List<T> List { get; set; }

        public PagedSearchVO()
        {
        }

        public PagedSearchVO(int currentPage, int pageSIze, string sortedFields, string sortDirections)
        {
            CurrentPage = currentPage;
            PageSize = pageSIze;
            SortedFields = sortedFields;
            SortDirections = sortDirections;
        }

        public PagedSearchVO(int currentPage, int pageSize, string sortedFields, string sortDirections, Dictionary<string, object> filters)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            SortedFields = sortedFields;
            SortDirections = sortDirections;
            Filters = filters;
        }

        public PagedSearchVO(int currentPage, string sortedFields, string sortDirections) : this(currentPage, 10, sortedFields, sortDirections) 
        { }

        public int GetCurrentPage()
        {
            return CurrentPage == 0 ? 2 : CurrentPage;
        }
        
        public int GetCurrentSize()
        {
            return CurrentPage == 0 ? 10 : PageSize;
        }
    }
}
