namespace ConsoleApp2.LessonSix
{
    internal class BankAccount
    {
        protected decimal _money;
        protected string _pinCode;
        internal string Name { get; private set; }

        //protected Action<string> ActionGood;
        //protected Action<string> ActionError;
        public event Action<string> ActionGood;
        public event Action<string> ActionError;

        public BankAccount(decimal money, string pin, string name /*,Action<string> actionGood, Action<string> actionError*/)
        {
            _money = money;
            _pinCode = pin;
            Name = name;
            //ActionGood = actionGood;
            //ActionError = actionError;
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
                        ActionGood?.Invoke($"Недостаточно средств на счёте");
                    }
                    else
                    {
                        _money -= sum;
                        ActionGood?.Invoke($"Со счёта снято: {sum}");
                    }
                }
                else
                {
                    ActionError?.Invoke($"Неизвестная ошибка");
                }
            }
            else
            {
                ActionError?.Invoke("Пин-код не верный!");
            }
        }

        internal virtual (bool, int) Deposit(string pin, decimal sum) //положить деньги
        {
            if (pin == _pinCode)
            {
                if (sum > 0)
                {
                    _money += sum;
                    ActionGood?.Invoke($"На счёт добавлено: {sum}");
                    return (true, (int)sum);
                }
                else
                {
                    ActionError?.Invoke($"Неизвестная ошибка");
                    return (true, 0);
                }
            }
            else
            {
                ActionError?.Invoke("Пин-код не верный!");
                return (false, 0);
            }
        }

        internal virtual bool CheckBalance(string pin) //просмотреть сумму на счёте
        {
            if (pin == _pinCode)
            {
                ActionGood?.Invoke($"Сумма на счёте: {_money}");
                return true;
            }
            else
            {
                //throw new Exception("Пин-код не верный!");
                ActionError?.Invoke("Пин-код не верный!");
                return false;
            }
        }
    }
}
