using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knitting_Products.Models
{
    public class Product
    {
        public int ID { get; set; }

        public double Price { get; set; }

        public string Img { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}