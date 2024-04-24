namespace ConsoleApp2.LessonOne
{
    internal class Program
    {
        internal static void Start()
        {
            Point home = new Point() { x = 10, y = 20 };

            Share(home);

            Console.WriteLine($"Заказ {home.x} {home.y}");

            People people1 = new People("User")
            {
                Age = 20,
            };
            people1.Name = "chjsc";

            People people2 = new People("User");

            People peopleAdmin = new People("Admin");

            people1.Admin = peopleAdmin;

            Console.WriteLine($"Hello, {people1.Name} ({peopleAdmin.Name})!");

            //ConsoleApp2.Other.OtherPeople
        }

        static void Share(Point point)
        {
            point.y -= 5;
        }
    }
}
