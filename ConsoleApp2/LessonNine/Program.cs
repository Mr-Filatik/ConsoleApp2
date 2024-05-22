using Serilog;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2.LessonNine
{
    internal class Program
    {
        /// <summary>
        /// Что-то делает метод
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        internal static void Start()
        {
            try
            {
                int a = 1;
                //Console.WriteLine($"int a = {a};");
                Log.Information($"int a = {a};");

                int b = 0;
                //Console.WriteLine($"int b = {b};");
                Log.Information($"int a = {b};");

                double c = a / b;
                //Console.WriteLine("double c = a / b;");
                Log.Information($"double {c} = {a} / {b};");

                //Console.WriteLine();
                //Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Произошла ошибка\n {ex.Message}\n {ex.StackTrace}\n {ex.TargetSite}\n {ex.InnerException?.Message} ");
                Log.Error($"Произошла ошибка\n {ex.Message}\n {ex.StackTrace}\n {ex.TargetSite}\n {ex.InnerException?.Message}");
                //throw;
            }
        }

        //internal static void Start()
        //{
        //    try
        //    {
        //        int a = 1;
        //        Console.WriteLine("int a = 1;");
        //        int b = 0;
        //        Console.WriteLine("int b = 0;");
        //        double c = Start2(a, b);
        //        Console.WriteLine("double c = a / b;");

        //        Console.WriteLine();
        //        Console.WriteLine(c);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Произошла ошибка\n {ex.Message}\n {ex.StackTrace}\n {ex.TargetSite}\n {ex.InnerException?.Message} ");
        //    }
        //}

        //internal static double Start2(int a, int b)
        //{
        //    return Start3(a, b);
        //}

        //internal static double Start3(int a, int b)
        //{
        //    return a / b;
        //}
    }
}