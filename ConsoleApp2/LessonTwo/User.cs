namespace ConsoleApp2.LessonTwo
{
    internal class User : People
    {
        internal string UserName { get; set; }
        internal string Password { get; set; }

        public User() : base()
        {
            Console.WriteLine("Constructor class User");
        }

        public User(string userName, string password) : base()
        {
            Console.WriteLine("Constructor 2 class User");
            UserName = userName;
            Password = password;
        }

        public User(string userName, string password, string firstName, string lastName, string patronymic, int age) : base(firstName, lastName, patronymic, age)
        {
            Console.WriteLine("Constructor 3 class User");
            UserName = userName;
            Password = password;
        }
    }
}
