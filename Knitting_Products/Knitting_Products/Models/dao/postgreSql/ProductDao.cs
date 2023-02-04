using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

using Npgsql;

namespace Knitting_Products.Models.dao.postgreSql
{
    public class ProductDao : AbstractDao, IProductDao
    {
        public void Create(Product obj)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert into \"Products\" (price, img, date, description) values ("+obj.Price.ToString()+", "+obj.Img+", "+obj.Date+", "+obj.Description+");";
            NpgsqlCommand command = new NpgsqlCommand(query,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(Product obj)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select id, price, img, date, description from \"Products\" WHERE isordered=false;";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            List<Product> res = new List<Product>();
            foreach (DataRow row in dt.Rows)
            {
                Product product = new Product();
                product.ID =(int)row["id"];
                product.Price = (double)row["price"];
                product.Img = (string)row["img"];
                product.Date = (DateTime)row["date"];
                product.Description = (string)row["description"];
                res.Add(product);
            }
            connection.Close();
            return res;
        }

        public Product Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}