namespace ConsoleApp2.LessonTwo
{
    internal class Admin : User
    {
        internal string SuperPassword { get; set; }

        public Admin() : base()
        {
            Console.WriteLine("Constructor class Admin");
        }
    }
}
