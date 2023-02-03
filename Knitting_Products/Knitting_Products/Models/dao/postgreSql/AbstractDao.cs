using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knitting_Products.Models.dao.postgreSql
{
    public class AbstractDao
    {
        protected string connectionString = "Host=localhost;Username=postgres;Password=1;Database=toysshop";
    }
}