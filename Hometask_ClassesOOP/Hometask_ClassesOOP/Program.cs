using System;
using System.Collections.Generic;
using NLog;

namespace Hometask_ClassesOOP
{
    class Program
    {
        public static Logger log = LogManager.GetCurrentClassLogger();

        [My(Name = "Даниил", Surname = "Ефремов", Age = 21)]
        static void Main(string[] args)
        {
            List<Washing_Machines> wm = new List<Washing_Machines>();
            List<Vacuum_Cleaners> vc = new List<Vacuum_Cleaners>();
            log.Debug("Создано 2 списка");

            wm.Add(new Washing_Machines("LG101", "Серый", 5999.99d, 2000, true, false));
            vc.Add(new Vacuum_Cleaners("Samsung201", "Красный", 4399.99d, 1000, false, "Автомобиль"));
            log.Debug("В списки добавлено по 1 объекту");

            Console.WriteLine("Желаете добавить еще объект? (да/нет)");

            string key = Console.ReadLine();

            if (key == "ДА" || key == "Да" || key == "Lf" || key == "lf" || key == "LF")
            {
                key = "да";
            }

            if (key == "НЕТ" || key == "Нет" || key == "Ytn" || key == "ytn" || key == "YTN")
            {
                key = "нет";
            }

            try
            {
                switch (key)
                {
                    case "да":
                        {
                            do
                            {
                                Console.WriteLine("\nВыберите класс объекта: (1/2)?\n1 - Стиральная машинка\n2 - Пылесос");
                                int innerkey = int.Parse(Console.ReadLine());
                                log.Debug("Произведен выбор списка записи");
                                switch (innerkey)
                                {
                                    case 1:
                                        {
                                            Console.Write("\nВведите название прибора: ");
                                            string name1 = Console.ReadLine();
                                            log.Trace("Введено название прибора");
                                            Console.Write("Введите цвет прибора: ");
                                            string colour1 = Console.ReadLine();
                                            log.Trace("Введен цвет прибора");
                                            Console.Write("Введите цену прибора: ");
                                            double price1 = double.Parse(Console.ReadLine());
                                            log.Trace("Введена цена прибора");
                                            Console.Write("Введите мощность прибора: ");
                                            int power1 = int.Parse(Console.ReadLine());
                                            log.Trace("Введена мощность прибора");
                                            Console.Write("Имеется ли режим отжима (true/false): ");
                                            bool spin1 = bool.Parse(Console.ReadLine());
                                            log.Trace("Выбрано наличие режима отжима");
                                            Console.Write("Имеется ли деликатный режим (true/false): ");
                                            bool gentle1 = bool.Parse(Console.ReadLine());
                                            log.Trace("Выбрано наличие деликатного режима");
                                            wm.Add(new Washing_Machines(name1, colour1, price1, power1, spin1, gentle1));
                                            log.Debug("Добавлен очередной объект в список стиральных машиное");

                                            break;
                                        }

                                    case 2:
                                        {
                                            Console.Write("\nВведите название прибора: ");
                                            string name1 = Console.ReadLine();
                                            log.Trace("Введено название прибора");
                                            Console.Write("Введите цвет прибора: ");
                                            string colour1 = Console.ReadLine();
                                            log.Trace("Введен цвет прибора");
                                            Console.Write("Введите цену прибора: ");
                                            double price1 = double.Parse(Console.ReadLine());
                                            log.Trace("Введена цена прибора");
                                            Console.Write("Введите мощность прибора: ");
                                            int power1 = int.Parse(Console.ReadLine());
                                            log.Trace("Введена мощность прибора");
                                            Console.Write("Имеется ли режим влажной уборки (true/false): ");
                                            bool wet1 = bool.Parse(Console.ReadLine());
                                            log.Trace("Выбрано наличие режима влажной уборки");
                                            Console.Write("Что прибор должен убирать: ");
                                            string purpose1 = Console.ReadLine();
                                            log.Trace("Введена цель прибора");
                                            vc.Add(new Vacuum_Cleaners(name1, colour1, price1, power1, wet1, purpose1));
                                            log.Debug("Добавлен очередной объект в список пылесосов");

                                            break;
                                        }
                                }

                                Console.WriteLine("\nЖелаете добавить еще прибор? (да/нет)");
                                key = Console.ReadLine();
                            } while (key == "да");
                            log.Debug("Решено не добавлять новых объектов");
                            break;
                        }

                    case "нет":
                        {
                            log.Debug("Решено не добавлять новых объектов");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Некорректный ввод! Прибор добавлен не будет!");
                            log.Error("ОШИБКА! Некорректный ввод!");
                            break;
                        }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nВвод данных некорректного формата!");
                log.Error("ОШИБКА! Ввод данных некорректного формата!");
            }
            finally
            {
                int i = 0;
                Console.WriteLine("\nСписок стиральных машинок:");
                foreach (Washing_Machines w in wm)
                {
                    i++;
                    Console.WriteLine("Стиральная машика №{0}:", i);
                    w.PrintInf();
                }
                log.Debug("Вывод списка стиральных машинок на экран");

                int j = 0;
                Console.WriteLine("\nСписок пылесосов:");
                foreach (Vacuum_Cleaners v in vc)
                {
                    j++;
                    Console.WriteLine("Пылесос №{0}:", j);
                    v.PrintInf();
                }
                log.Debug("Вывод списка пылесосов на экран");
            }
        }
    }
}
