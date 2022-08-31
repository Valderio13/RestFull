using Rest.Model;
using Rest.Model.Base;
using System.Collections.Generic;

namespace Rest.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void delete(long id);
        bool Exists(long id);
    }
}
