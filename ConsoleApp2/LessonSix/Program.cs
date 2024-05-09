namespace ConsoleApp2.LessonSix
{
    internal class Program
    {
        internal static void Start()
        {
            //BankAccount bankAccount = new BankAccount(100M, "1234", "Vlad", WriteGood, WriteBad);
            BankAccount bankAccount = new BankAccount(100M, "1234", "Vlad");

            bankAccount.ActionGood += WriteGood;

            bankAccount.ActionError += WriteBad;
            bankAccount.ActionError += WriteBadServer;

            bankAccount.Withdraw("1234", 10M);
            bankAccount.CheckBalance("1234");
            bankAccount.Withdraw("1234", 10M);
            bankAccount.CheckBalance("1234");
            bankAccount.Withdraw("12341", 10M);
            bankAccount.CheckBalance("1234");
            bankAccount.Withdraw("12341", 10M);
            bankAccount.CheckBalance("1234");
            bankAccount.Withdraw("12341", 10M);
            bankAccount.CheckBalance("1234");
            bankAccount.Withdraw("12341", 10M);
            bankAccount.CheckBalance("1234");

            #region Reg

            //int a1 = 1;
            //int a2 = 2;

            //string s1 = "xhjcs";
            //string s2 = "!!!!!";

            //Swap<int>(ref a1, ref a2);
            //Swap<string>(ref s1, ref s2);

            //Console.WriteLine($"{a1} - {a2}");
            //Console.WriteLine($"{s1} - {s2}");

            //Console.WriteLine("1");
            //User<int> user1 = new User<int>();
            //Console.WriteLine("2");
            //User<int>.Type = "type1";
            //Console.WriteLine("3");
            //User<string> user2 = new User<string>();
            //Console.WriteLine("4");
            //User<string>.Type = "type2";

            //Console.WriteLine(User<int>.Type);

            #endregion  
        }

        internal static void WriteGood(string message) 
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void WriteBad(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void WriteBadServer(string error)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Server - {error}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }

    internal class User<T>
    {
        public T Id { get; set; } //10002267 // 7A10C827-7F73-4993-9A9A-F7D208E2D3F4
        public string Name { get; set; }
        public string Password { get; set; }
        public static string Type { get; set; }

        static User()
        {
            Console.WriteLine("ctor");
        }
    }
}