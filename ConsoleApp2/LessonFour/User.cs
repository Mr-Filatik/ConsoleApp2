namespace ConsoleApp2.LessonFour
{
    internal class User : People
    {
        internal string UserName { get; set; }
        internal string Password { get; set; }

        internal override void Login()
        {
            Console.WriteLine("Добро пожаловать на ресурс!");
        }

        #region Constructors


        #endregion
    }
}
