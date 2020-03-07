using System;

namespace P18_9
{
    class Creditor : Client //кредитор
    {
        private float Loan_Amount; //размер кредита
        private int Interest_Loan; //процент по кредиту
        private float Balance_Owed; //остаток долга
        protected static readonly string nametype = "Creditor";
        public Creditor(string surname, int year, int month, int day, float size_money, int procent, float debt)
            : base(surname, new DateTime(year, month, day))
        {
            Loan_Amount = size_money;
            Interest_Loan = procent;
            Balance_Owed = debt;
        }
        public override string Name()
        {
            return nametype;
        }

        public override void Show()
        {
            Console.WriteLine($"Кредитор {Surname}\nДата открытия кредита {date.ToString("d")}\nСумма которого {Loan_Amount} рублей " +
                $"под {Interest_Loan}% процентов годовых\nОставшийся размер возрата {Balance_Owed}");
        }
    }
}
