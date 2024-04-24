namespace ConsoleApp2.LessonTwo
{
    internal class People
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string Patronymic { get; set; }
        internal int Age { get; set; }

        public People()
        {
            Console.WriteLine("Constructor class People");
        }

        public People(string firstName, string lastName, string patronymic, int age)
        {
            Console.WriteLine("Constructor 2 class People");
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Age = age;
        }
    }
}
