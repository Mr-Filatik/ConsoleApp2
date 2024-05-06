using ConsoleApp2.LessonFive.BLL;
using ConsoleApp2.LessonFive.DAL;
using ConsoleApp2.LessonFive.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.LessonFive
{
    internal class CoffeeMashine
    {
        private ICoffeeDatabase _database;
        private CoffeeManager _manager;
        private CoffeeConsole _console;

        public CoffeeMashine()
        {
            _database = new CoffeeDatabase();
            _manager = new CoffeeManager(_database);
            _console = new CoffeeConsole();
        }

        internal void Run()
        {
            while (true)
            {
                int number = _console.Start(_manager.GetAssortiment());
                var product = _manager.SelectProduct(number);
                decimal money = _console.Enter(product.Name, product.Price);
                while (money < product.Price)
                {
                    money += _console.Buy(money, product.Price);
                }
                _console.Final(product.Name);
            }
        }
    }
}
