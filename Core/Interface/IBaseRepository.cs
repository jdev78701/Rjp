using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IBaseRepository<T> where T: class
    {
        #region Get
        T GetById(int ?id=0);
        IEnumerable<T> GetAll();
        #endregion

        #region Add
        T Add(T entity);
        #endregion

        #region Update
        T Update(T entity);
        #endregion

    }
}
