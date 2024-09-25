using RESTFulAPI.Data.VO;
using RESTFulAPI.Model;

namespace RESTFulAPI.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disabled(long id);
    }
}
