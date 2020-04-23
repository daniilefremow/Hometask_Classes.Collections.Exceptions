using System;
using System.Collections.Generic;

namespace Hometask_ClassesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Washing_Machines> wm = new List<Washing_Machines>();
            List<Vacuum_Cleaners> vc = new List<Vacuum_Cleaners>();

            wm.Add(new Washing_Machines("LG101", "Серый", 5999.99d, 2000, true, false));
            vc.Add(new Vacuum_Cleaners("Samsung201", "Красный", 4399.99d, 1000, false, "Автомобиль"));

            Console.WriteLine("Желаете добавить еще прибор? (да/нет)");

            string key = Console.ReadLine();

            switch (key)
            {
                case "да":
                    {
                        do
                        {
                            Console.WriteLine("\nВыберите класс объекта: (1/2)?\n1 - Стиральная машинка\n2 - Пылесос");
                            int innerkey = int.Parse(Console.ReadLine());

                            switch (innerkey)
                            {
                                case 1:
                                    {
                                        Console.Write("\nВведите название прибора: ");
                                        string name1 = Console.ReadLine();
                                        Console.Write("Введите цвет прибора: ");
                                        string colour1 = Console.ReadLine();
                                        Console.Write("Введите цену прибора: ");
                                        double price1 = double.Parse(Console.ReadLine());
                                        Console.Write("Введите мощность прибора: ");
                                        int power1 = int.Parse(Console.ReadLine());
                                        Console.Write("Имеется ли режим отжима (true/false): ");
                                        bool spin1 = bool.Parse(Console.ReadLine());
                                        Console.Write("Имеется ли деликатный режим (true/false): ");
                                        bool gentle1 = bool.Parse(Console.ReadLine());
                                        wm.Add(new Washing_Machines(name1, colour1, price1, power1, spin1, gentle1));

                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Write("\nВведите название прибора: ");
                                        string name1 = Console.ReadLine();
                                        Console.Write("Введите цвет прибора: ");
                                        string colour1 = Console.ReadLine();
                                        Console.Write("Введите цену прибора: ");
                                        double price1 = double.Parse(Console.ReadLine());
                                        Console.Write("Введите мощность прибора: ");
                                        int power1 = int.Parse(Console.ReadLine());
                                        Console.Write("Имеется ли режим влажной уборки (true/false): ");
                                        bool wet1 = bool.Parse(Console.ReadLine());
                                        Console.Write("Что прибор должен убирать: ");
                                        string purpose1 = Console.ReadLine();
                                        vc.Add(new Vacuum_Cleaners(name1, colour1, price1, power1, wet1, purpose1));

                                        break;
                                    }
                            }

                            Console.WriteLine("\nЖелаете добавить еще прибор? (да/нет)");
                            key = Console.ReadLine();
                        } while (key == "да");
                        break;
                    }

                case "нет":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Некорректный ввод! Прибор добавлен не будет!");
                        break;
                    }

            }

            int i = 0;
            Console.WriteLine("\nСписок стиральных машинок:");
            foreach (Washing_Machines w in wm)
            {
                i++;
                Console.WriteLine("Стиральная машика №{0}:",i);
                w.PrintInf();
            }

            int j = 0;
            Console.WriteLine("\nСписок пылесосов:");
            foreach (Vacuum_Cleaners v in vc)
            {
                j++;
                Console.WriteLine("Пылесос №{0}:", j);
                v.PrintInf();
            }


            Console.WriteLine();
        }
    }
}
