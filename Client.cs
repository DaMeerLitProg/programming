using System;

namespace P18_9
{
    abstract class Client : IComparable
    {
        protected string Surname;
        protected DateTime date;
        protected Client(string surname, DateTime date)
        {
            Surname = surname;
            this.date = date;
        }

        abstract public void Show();
        abstract public string Name();
        public bool IsTrueDate(DateTime data)
        {
            if (this.date == data)
            {
                return true;
            }
            else return false;
        }
        public int CompareTo(object obj)
        {
            Client b = (Client)obj; //преобразуем параметр к типу IPoint
                                        //определяем критерии сравнения текущего объекта с параметром в
                                        // зависимости от удаленности точки от начала координат
            if (this.date == b.date)
            {
                return 0;
            }
            else
            {
                if (this.date > b.date)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
