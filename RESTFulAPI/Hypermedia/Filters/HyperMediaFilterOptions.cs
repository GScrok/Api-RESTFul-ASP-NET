using RESTFulAPI.Hypermedia.Abstract;

namespace RESTFulAPI.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList {  get; set; } = new List<IResponseEnricher>();
    }
}
