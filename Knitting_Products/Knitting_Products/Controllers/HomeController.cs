using Knitting_Products.Models;
using Knitting_Products.Models.dao;
using Knitting_Products.Models.dao.postgreSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knitting_Products.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IProductDao productDao = new ProductDao();
            List<Product> list = productDao.GetProducts();
            list.Sort((list1, list2) => list1.Date.CompareTo(list1.Date));
            list.Reverse();
            while (list.Count>5)
            {
                list.RemoveAt(list.Count - 1);
            }
            ViewBag.list = list;
            return View();
        }

        public ActionResult Catalog()
        {
            IProductDao productDao = new ProductDao();
            List<Product> list = productDao.GetProducts();
            list.Sort((list1, list2) => list1.Date.CompareTo(list1.Date));
            list.Reverse();
            ViewBag.list = list;

            return View();
        }
    }
}