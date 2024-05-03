namespace ConsoleApp2.LessonFour
{
    internal class Program
    {
        internal static void Start()
        {
            People[] peoples = { new User(), new Admin() };

            foreach (var item in peoples)
            {
                Login(item);
            }

            IFlyeble[] flyebles = { new Airplane(), new Helicopter(), new Butterfly() };
        }

        internal static void Login(People people)
        {
            //switch (people)
            //{
            //    case Admin:
            //        ((Admin)people).Login();
            //        break;
            //    case User:
            //        ((User)people).Login();
            //        break;
            //    default:
                    people.Login();
            //        break;
            //}
        }
    }

    internal class Airplane : IFlyeble
    {
        public void Fly()
        {
            //
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }

    internal class Helicopter : IFlyeble
    {
        public void Fly()
        {
            //
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }

    internal class Butterfly : IFlyeble
    {
        public void Fly()
        {
            //
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IFlyeble
    {
        void Fly();
        void TakeOff();
        //
    }
}