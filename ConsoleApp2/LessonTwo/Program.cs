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
        }
    }
}
