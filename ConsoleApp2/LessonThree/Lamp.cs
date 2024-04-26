namespace ConsoleApp2.LessonThree
{
    internal class Lamp
    {
        private bool _isWork = false;
        internal bool IsWork
        {
            get { return _isWork; }
            private set { _isWork = value; }
        }

        internal void OnOff()
        {
            IsWork = !IsWork;
        }

        internal void CheckState()
        {
            if (IsWork)
            {
                Console.WriteLine("Work");
            }
            else
            {
                Console.WriteLine("Dont work");
            }
        }
    }
}
