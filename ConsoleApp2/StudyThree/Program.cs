namespace ConsoleApp2.StudyThree
{
    internal class Program
    {
        internal static void Start()
        {
            decimal startMoney = 100;

            bool res = BankAccount.Validate(startMoney);
            if (res)
            {
                BankAccount bankAccount = new SuperBankAccount(startMoney, "1234", "Андрей Ф.", 3);

                Console.WriteLine(bankAccount.Name);
                bankAccount.CheckBalance("1234");
                var ansver = bankAccount.Deposit("1234", 100M);
                if (ansver.Item1)
                {
                    Console.WriteLine($"Средсва успешно зачислены {ansver.Item2}.");
                }
                //res = bankAccount.CheckBalance("1244");
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
            }
        }
    }
}