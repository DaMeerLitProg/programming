using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

/* 
Задание 9 
1) Создать абстрактный класс Клиент с методами, 
* позволяющими вывести на экран информацию о клиентах банка, 
* а также определить соответствие клиента критерию поиска
2) Создать производные классы: 
* Вкладчик (фамилия, дата открытия вклада, размер вклада, процент по вкладу). 
* Кредитор (фамилия, дата выдачи кредита, размер кредита, процент по кредиту, остаток долга). 
* Организация (название, дата открытия счета, номер счета, сумма на счету) 
со своими методами : 
* вывода информации на экран и 
* определения соответствия дате (открытия вклада, выдаче кредита, открытия счета). 
3) Создать базу (массив) из n клиентов, вывести полную информацию из базы на экран, а 
также организовать поиск клиентов, начавших сотрудничать с банком с заданной даты. 
*/

namespace P18_9
{
    class Program
    {
        static void Main()
        {
            using (StreamReader fileIn = new StreamReader("c:/example/input.txt")) 
            {
                List<Client> client = new List<Client>();
                string line;
                while ((line = fileIn.ReadLine()) != null)
                {
                    char[] div = {',', ';'};
                    string[] parts = line.Split(div, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length > 0)
                    {
                        switch (parts[0])
                        {
                            case "cont":
                                client.Add(new Сontributor(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                                break;
                            case "cred":
                                client.Add(new Creditor(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                                break;
                            case "org":
                                client.Add(new Organization(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                                    break;
                        }
                    }
                }
                    client.Sort();
                foreach (var obj_class in client)
                {
                    switch (obj_class.Name())
                    {
                        case "Сontributor":
                            Console.WriteLine("\nВКЛАДЧИК\n");
                            obj_class.Show();
                            break;
                        case "Creditor":
                            Console.WriteLine("\nКРЕДИТОР\n");
                            obj_class.Show();
                            break;
                        case "Organization":
                            Console.WriteLine("\nОРГАНИЗАЦИЯ\n");
                            obj_class.Show();
                            break;
                    }
                }
                Console.WriteLine("\n Поиск клиентов с заданой датой для сотрудничевства: ");
                Console.WriteLine("\n Введите дату (формат: гггг, мм, дд) для проверки: ");
                DateTime zdate = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                int ClientFound = 0;
                foreach (var x in client)
                {
                    if (x.IsTrueDate(zdate))
                    {
                        x.Show();
                        Console.WriteLine(" ");
                        ClientFound++;
                    }
                }
                Console.WriteLine("Людей, начавших сотрудничать с {0} найдено {1}", zdate.ToString("d"), ClientFound);
            }
            Console.ReadKey();
        }
    }
}