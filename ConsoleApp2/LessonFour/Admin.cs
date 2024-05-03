namespace ConsoleApp2.LessonFour
{
    internal class Admin : User
    {
        internal string SuperPassword { get; set; }

        internal override void Login()
        {
            Console.WriteLine("Добро пожаловать в панель управления ресурсом!");
        }
    }
}
