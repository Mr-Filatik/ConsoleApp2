using ConsoleApp2.LessonThree.Library;

namespace ConsoleApp2.LessonThree
{
    public class NewAllClass : AllClass
    {
        public NewAllClass()
        {
            ProtectedValue = true;
            ProtectedInternalValue = true;
        }
    }
}
