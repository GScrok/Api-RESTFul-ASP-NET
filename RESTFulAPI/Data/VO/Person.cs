using RESTFulAPI.Hypermedia;
using RESTFulAPI.Hypermedia.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTFulAPI.Data.VO
{
    public class PersonVO : ISupportHyperMedia
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender  { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
