using Rest.Model;
using System.Collections.Generic;

namespace Rest.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void delete(long id);
    }
}
