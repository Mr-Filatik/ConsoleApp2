using ConsoleApp2.LessonFive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.LessonFive.DAL
{
    internal interface ICoffeeDatabase
    {
        Product[] GetCurrentProducts();
        Product GetProductById(int id);
    }
}
