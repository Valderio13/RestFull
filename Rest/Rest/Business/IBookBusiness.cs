using Rest.Data.VO;
using Rest.Model;
using System.Collections.Generic;

namespace Rest.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void delete(long id);
    }
}
