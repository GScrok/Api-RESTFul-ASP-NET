using RESTFulAPI.Data.VO;
using RESTFulAPI.Model;

namespace RESTFulAPI.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        PersonVO Disabled(long id);
        void Delete(long id);
    }
}
