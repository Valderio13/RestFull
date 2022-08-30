using Rest.Model;
using System.Collections.Generic;

namespace Rest.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void delete(long id);
        bool Exists(long id);
    }
}
