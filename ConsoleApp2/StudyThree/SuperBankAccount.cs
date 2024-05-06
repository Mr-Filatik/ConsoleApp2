namespace ConsoleApp2.StudyThree
{
    internal class SuperBankAccount : BankAccount
    {
        protected int _count;

        public SuperBankAccount(decimal money, string pin, string name, int count) : base(money, pin, name)
        {
            _count = count;
        }

        internal static bool Validate(decimal money)
        {
            return money >= 0;
        }

        internal override void Withdraw(string pin, decimal sum) //снять деньги
        {
            if (_count > 0)
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
                    Console.WriteLine($"Пин-код не верный {_count}!");
                    _count--;
                }
            }
            else
            {
                Console.WriteLine("Счёт заблокирован!");
            }
        }

        internal override (bool, int) Deposit(string pin, decimal sum) //положить деньги
        {
            if (_count > 0)
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
                    Console.WriteLine($"Пин - код не верный { _count}!");
                    _count--;
                }
            }
            else
            {
                Console.WriteLine("Счёт заблокирован!");
            }
            return (false, 0);
        }

        internal override bool CheckBalance(string pin) //просмотреть сумму на счёте
        {
            if (_count > 0)
            {
                if (pin == _pinCode)
                {
                    Console.WriteLine($"Сумма на счёте: {_money}");
                    return true;
                }
                else
                {
                    //throw new Exception("Пин-код не верный!");
                    Console.WriteLine($"Пин-код не верный {_count}!");
                    _count--;
                }
            }
            else
            {
                Console.WriteLine("Счёт заблокирован!");
            }
            return false;
        }
    }
}
