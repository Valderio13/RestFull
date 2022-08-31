using Rest.Model;
using Rest.Model.Context;
using Rest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rest.Business.Implemetations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
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

        public void delete(long id)
        {
            _repository.delete(id);
        }      
    }
}
