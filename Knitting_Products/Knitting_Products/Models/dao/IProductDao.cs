using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knitting_Products.Models.dao
{
    interface IProductDao:IBaseDao<Product>
    {
        List<Product> GetProducts();
    }
}
