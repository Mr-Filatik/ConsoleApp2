using ConsoleApp2.LessonFive.DAL;
using ConsoleApp2.LessonFive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.LessonFive.BLL
{
    internal class CoffeeManager
    {
        private ICoffeeDatabase _database;

        public CoffeeManager(ICoffeeDatabase database)
        {
            _database = database;
        }

        internal Product[] GetAssortiment()
        {
            return _database.GetCurrentProducts();
        }

        internal Product SelectProduct(int id)
        {
            var item = _database.GetProductById(id);
            // вызываются насосы ...
            return item;
        }

        internal bool BuyProduct(int id, decimal money)
        {
            var item = _database.GetProductById(id);

            return money >= item.Price;

            //вычитание количества товара
        }
    }
}
