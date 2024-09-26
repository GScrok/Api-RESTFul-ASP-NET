using RESTFulAPI.Model;
using RESTFulAPI.Model.Context;
using RESTFulAPI.Repository.Generic;

namespace RESTFulAPI.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(MySQLContext context) : base(context)
        {
        }

        public Person Disabled(long id)
        {
            if (!_context.Persons.Any(p => p.Id.Equals(id))) return null;
            var user = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (user != null)
            {
                user.Enabled = false;
                try
                {
                    _context.Entry(user).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return user;
        }

        public List<Person> FindByName(string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p =>
                    p.FirstName.Contains(firstName) &&
                    p.LastName.Contains(lastName)).ToList();
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                return _context.Persons.Where(p =>
                    p.FirstName.Contains(firstName)).ToList();
            }
            else if (!string.IsNullOrEmpty(lastName))
            {
                return _context.Persons.Where(p =>
                    p.LastName.Contains(lastName)).ToList();
            }
            else return null;
        }
    }
}
