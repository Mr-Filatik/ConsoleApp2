namespace ConsoleApp2.LessonTwo
{
    internal class Program
    {
        internal static void Start()
        {
            People people = new People();
            people.FirstName = "Test";
            people.LastName = "Test";
            people.Patronymic = "Test";
            people.Age = 1;

            Console.WriteLine();

            User user = new User();
            user.FirstName = "Test";
            user.LastName = "Test";
            user.Patronymic = "Test";
            user.Age = 1;
            user.UserName = "Test";
            user.Password = "Test";

            Console.WriteLine();

            Admin admin = new Admin();
            admin.FirstName = "Test";
            admin.LastName = "Test";
            admin.Patronymic = "Test";
            admin.Age = 1;
            admin.UserName = "Test";
            admin.Password = "Test";
            admin.SuperPassword = "Test";

            Console.WriteLine();

            People pp = new People() { Age = 1 };
            People pu = new User() { Age = 2 };
            People pa = new Admin() { Age = 3 };
            //User up = new People();
            User uu = new User() { Age = 4 };
            User ua = new Admin() { Age = 5 };
            //Admin ap = new People();
            //Admin au = new User();
            Admin aa = new Admin() { Age = 6 };

            People[] peoples = { pp, pu, pa, uu, ua, aa };
            foreach (var item in peoples)
            {
                GetInfo(item);
            }
        }

        internal static void GetInfo(People people)
        {
            //Admin admin = (Admin)people;

            // 1
            //if (people is Admin)
            //{
            //    Console.WriteLine("Admin");
            //    var admin = (Admin)people; //!!!!
            //    Console.WriteLine(admin.SuperPassword);
            //}

            // 2
            //Admin admin = people as Admin;
            //if (admin != null)
            //{
            //    Console.WriteLine("Admin");
            //}

            //User user = people as User;
            //if (user != null)
            //{
            //    Console.WriteLine("User");
            //}

            //if (people != null)
            //{
            //    Console.WriteLine("People");
            //}

            // 3
            //switch (people)
            //{
            //    case Admin:
            //        Console.WriteLine("Admin");
            //        var admin = (Admin)people; //!!!!
            //        Console.WriteLine(admin.SuperPassword);
            //        break;
            //    case User:
            //        Console.WriteLine("User");
            //        break;
            //    default:
            //        Console.WriteLine("People");
            //        break;
            //}
            Console.WriteLine(people.Age);
        }
    }
}
