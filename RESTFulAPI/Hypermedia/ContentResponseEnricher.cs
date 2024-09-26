using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using RESTFulAPI.Hypermedia.Abstract;
using RESTFulAPI.Hypermedia.Utils;
using System.Collections.Concurrent;

namespace RESTFulAPI.Hypermedia
{
    public abstract class ContentResponseEnricher<T> : IResponseEnricher where T : ISupportHyperMedia
    {
        public ContentResponseEnricher()
        {

        }
        public bool CanEnrich(Type contentType)
        {
            return contentType == typeof(T) || contentType == typeof(List<T>) || contentType == typeof(PagedSearchVO<T>);
        }

        protected abstract Task EnrichModel(T content, IUrlHelper urlHelper);

        bool IResponseEnricher.CanEnrich(ResultExecutingContext response)
        {
            if (response.Result is OkObjectResult okObjectResult)
            {
                return CanEnrich(okObjectResult.Value.GetType());
            }
            return false;
        }

        public async Task Enrich(ResultExecutingContext response)
        {
            var urlHelper = new UrlHelperFactory().GetUrlHelper(response);
            if (response.Result is OkObjectResult okObjectResult)
            {
                if(okObjectResult is T model)
                {
                    await EnrichModel(model, urlHelper);
                }
                else if (okObjectResult is List<T> collection)
                {
                    ConcurrentBag<T> bag = new ConcurrentBag<T>(collection);
                    Parallel.ForEach(bag, (elemnt) =>
                    {
                        EnrichModel(elemnt, urlHelper);
                    });
                }
                else if (okObjectResult is PagedSearchVO<T> pagedSearch)
                {
                    Parallel.ForEach(pagedSearch.List.ToList(), (elemnt) =>
                    {
                        EnrichModel(elemnt, urlHelper);
                    });
                }
                await Task.FromResult<object>(null);
            }
        }
    }
}
