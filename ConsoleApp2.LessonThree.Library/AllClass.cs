namespace ConsoleApp2.LessonThree.Library
{
    public class AllClass
    {
        public bool PublicValue { get; set; }
        internal bool InternalValue { get; set; }
        protected internal bool ProtectedInternalValue { get; set; }
        protected bool ProtectedValue { get; set; }
        private protected bool PrivateProtectedValue { get; set; }
        private bool PrivateValue { get; set; }

        public AllClass()
        {
            ProtectedValue = true;
            PrivateValue = false;
        }
    }

    public class AllSuperClass : AllClass
    {
        public AllSuperClass()
        {
            ProtectedValue = true;
            ProtectedInternalValue = false;
            PrivateProtectedValue = false;
        }
    }
}
