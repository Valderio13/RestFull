using Rest.Data.VO;
using System.Collections.Generic;

namespace Rest.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void delete(long id);
    }
}
