using Rest.Model;
using System.Collections.Generic;

namespace Rest.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void delete(long id);
    }
}
