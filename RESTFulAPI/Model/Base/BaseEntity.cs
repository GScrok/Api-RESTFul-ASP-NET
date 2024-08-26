using System.ComponentModel.DataAnnotations.Schema;

namespace RESTFulAPI.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
