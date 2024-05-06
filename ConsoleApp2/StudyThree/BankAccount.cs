namespace ConsoleApp2.StudyThree
{
    internal class BankAccount
    {
        protected decimal _money;
        protected string _pinCode;
        internal string Name { get; private set; }

        public BankAccount(decimal money, string pin, string name)
        {
            _money = money;
            _pinCode = pin;
            Name = name;
        }

        internal static bool Validate(decimal money)
        {
            return money >= 0;
        }

        internal virtual void Withdraw(string pin, decimal sum) //снять деньги
        {
            if (pin == _pinCode)
            {
                if (sum > 0)
                {
                    if (_money < sum)
                    {
                        Console.WriteLine($"Недостаточно средств на счёте");
                    }
                    else
                    {
                        _money -= sum;
                        Console.WriteLine($"Со счёта снято: {sum}");
                    }
                }
                else
                {
                    Console.WriteLine($"Неизвестная ошибка");
                }
            }
            else
            {
                Console.WriteLine("Пин-код не верный!");
            }
        }

        internal virtual (bool, int) Deposit(string pin, decimal sum) //положить деньги
        {
            if (pin == _pinCode)
            {
                if (sum > 0)
                {
                    _money += sum;
                    //Console.WriteLine($"На счёт добавлено: {sum}");
                    return (true, (int)sum);
                }
                else
                {
                    //Console.WriteLine($"Неизвестная ошибка");
                    return (true, 0);
                }
            }
            else
            {
                //Console.WriteLine("Пин-код не верный!");
                return (false, 0);
            }
        }

        internal virtual bool CheckBalance(string pin) //просмотреть сумму на счёте
        {
            if (pin == _pinCode)
            {
                Console.WriteLine($"Сумма на счёте: {_money}");
                return true;
            }
            else
            {
                //throw new Exception("Пин-код не верный!");
                Console.WriteLine("Пин-код не верный!");
                return false;
            }
        }
    }
}
