using Rest.Model;
using Rest.Model.Context;
using Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rest.Business.Implemetations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void delete(long id)
        {
            _repository.delete(id);
        }      
    }
}
