using RESTFulAPI.Model;

namespace RESTFulAPI.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindByID(long book);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}