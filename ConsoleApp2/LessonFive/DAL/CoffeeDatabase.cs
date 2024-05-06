using ConsoleApp2.LessonFive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2.LessonFive.DAL
{
    internal class CoffeeDatabase : ICoffeeDatabase
    {
        private Product[] _currentProducts = new Product[] 
        {
            new Product() { Id = 1, Name = "Латте", Price = 50 },
            new Product() { Id = 2, Name = "Капучино", Price = 40 },
            new Product() { Id = 3, Name = "Американо", Price = 50 },
        };

        public Product[] GetCurrentProducts()
        {
            return _currentProducts;
        }

        public Product GetProductById(int id)
        {
            return _currentProducts.FirstOrDefault(x => x.Id == id);
        }
    }
}
