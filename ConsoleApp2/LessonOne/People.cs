namespace ConsoleApp2.LessonOne
{
    internal class People
    {
        internal string Name { get; set; }

        internal int age;
        internal int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("=(");
                }
            }
        }
        internal People Admin { get; set; }

        public People(string name)
        {
            Name = name;
        }
    }
}
