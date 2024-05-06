﻿using ConsoleApp2.LessonFive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2.LessonFive.PL
{
    internal class CoffeeConsole
    {
        internal int Start(Product[] items)
        {
            Console.WriteLine("Вот ассортимент!");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id}: {item.Name} - {item.Price}");
            }
            Console.WriteLine();
            Console.WriteLine("Выберите продукт!");
            return int.Parse(Console.ReadLine());
        }

        internal decimal Enter(string name, decimal price)
        {
            Console.WriteLine($"Почти начали готовить {name}, нужно только оплатить...");
            Console.WriteLine();
            Console.WriteLine($"Внесите сумму (0 из {price})!");
            return decimal.Parse(Console.ReadLine());
        }

        internal decimal Buy(decimal current, decimal price)
        {
            Console.WriteLine($"Добавьте денег ({current} из {price})...");
            return decimal.Parse(Console.ReadLine());
        }

        internal void Final(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"Приятного дня! Вот ваш {name}.");
            Console.WriteLine();
        }
    }
}
