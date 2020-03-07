using System;

namespace P18_9
{
    class Organization : Client
    {
        private string Name_Company; //наименование организации
        private int AccountNumber; //номер счёта
        private float Account_Amount; //сумма на счету
        protected static readonly string nametype = "Organization";
        public Organization(string name, int year, int month, int day, int number, float amount)
            : base(name, new DateTime(year, month, day))
        {
            Name_Company = name;
            AccountNumber = number;
            Account_Amount = amount;
        }
        public override string Name()
        {
            return nametype;
        }
        public override void Show()
        {
            Console.WriteLine($"Организация {Name_Company}\nОткрыла счёт клиенту с номером {AccountNumber}" +
                $"\n{date.ToString("d")} числа\nКлиент имеет еще на счету {Account_Amount}");
        }
        
    }
}
