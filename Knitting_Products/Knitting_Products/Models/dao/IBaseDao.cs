using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knitting_Products.Models.dao
{
    public interface IBaseDao<T>
    {
        void Create(T obj);

        T Read(int id);

        void Update(T obj);

        void Delete(T obj);

    }
}
