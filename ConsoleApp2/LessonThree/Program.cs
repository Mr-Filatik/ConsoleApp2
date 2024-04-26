using ConsoleApp2.LessonThree.Library;

namespace ConsoleApp2.LessonThree
{
    internal class Program
    {
        internal static void Start()
        {
            Lamp lamp = new Lamp();
            lamp.CheckState();
            //lamp.IsWork = true;
            lamp.OnOff();
            lamp.CheckState();

            PublicClass pc = new PublicClass();
            //InternalClass ic = new InternalClass(); //ERROR
        }
    }
}