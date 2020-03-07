using System;

namespace P18_9
{
    class Сontributor : Client // вкладчик
    {
        protected float Deposit_Size; //размер вклада
        protected int Interest_Deposit; //процент по вкладу       
        protected static readonly string nametype = "Сontributor";
        public Сontributor(string surname, int year, int month, int day, float size_money, int procent) 
            : base(surname, new DateTime(year, month, day))
        {
            Deposit_Size = size_money;
            Interest_Deposit = procent;
        }
        public override string Name()
        {
            return nametype;
        }

        public override void Show()
        {
            Console.WriteLine($"Вкладчик {Surname}\nОткрыл вклад {date.ToString("d")}\nИмеет размер вклада {Deposit_Size} " +
                $"рублей под {Interest_Deposit}% процентов годовых");
        }
    }
}
