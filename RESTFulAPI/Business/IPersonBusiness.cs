using RESTFulAPI.Data.VO;
using RESTFulAPI.Hypermedia.Utils;
using RESTFulAPI.Model;

namespace RESTFulAPI.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        List<PersonVO> FindAll();
        PagedSearchVO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
        PersonVO FindByID(long id);
        List<PersonVO> FindByName(string? firstName, string? lastName);
        PersonVO Update(PersonVO person);
        PersonVO Disabled(long id);
        void Delete(long id);
    }
}
