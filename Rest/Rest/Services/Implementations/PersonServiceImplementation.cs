using Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rest.Services.Implemetations
{
    public class PersonServiceImplementation : IPersonService
    {
        public volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            };
            return persons;
        }


        public Person FindByID(long id)
        {
            return new Person
            {
                id = IcrementAndGet(),
                FirstName = "Valderio",
                LastName = "Junior",
                Adress = "São Paulo - SP - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                id = IcrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Adress = "Some Adress" + i,
                Gender = "Male"
            };
        }

        private long IcrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
