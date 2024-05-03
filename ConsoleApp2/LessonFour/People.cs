namespace ConsoleApp2.LessonFour
{
    internal abstract class People
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string Patronymic { get; set; }
        internal int Age { get; set; }

        internal abstract void Login();
    }
}
