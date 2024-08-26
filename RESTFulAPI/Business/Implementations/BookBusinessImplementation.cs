using RESTFulAPI.Model;
using RESTFulAPI.Model.Context;
using RESTFulAPI.Repository;
using System;

namespace RESTFulAPI.Business.Implementations
{
    public class BookBusinessRepository : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        public BookBusinessRepository(IRepository<Book> repository) 
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }
        public Book Update(Book book)
        {
            return _repository.Update(book);

        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
