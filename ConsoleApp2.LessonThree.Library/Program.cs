namespace ConsoleApp2.LessonThree.Library
{
    public class Program
    {
        internal static void Start()
        {
            AllClass allClass = new AllClass();
            allClass.PublicValue = true;
            allClass.InternalValue = true;
            allClass.ProtectedInternalValue = true;
        }
    }
}
