using System;
using System.Linq;
using System.Collections.Generic;

namespace Hometask_ClassesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Appliances> apps = new List<Appliances>();

            Washing_Machines LG101 = new Washing_Machines("LG101", "Серый", 5999.99d, 2000, true, false);
            apps.Add(LG101);

            Washing_Machines Polaris333 = new Washing_Machines("Polaris333", "Белый", 13399.99d, 3500, true, true);
            apps.Add(Polaris333);

            Vacuum_Cleaners Samsung201 = new Vacuum_Cleaners("Samsung201", "Красный", 4399.99d, 1000, false, "Автомобиль");
            apps.Add(Samsung201);

            Vacuum_Cleaners LG390 = new Vacuum_Cleaners("LG390", "Черный", 21099.99d, 4000, true, "Квартира");
            apps.Add(LG390);

            Console.WriteLine("Введите необходимый параметр: Мощность, Цена, Название.");
            string key = Console.ReadLine();

            int i = 0;

            switch (key)
            {
                case "Мощность":
                    {
                        var result = from Appliances in apps
                                     orderby Appliances.power
                                     select Appliances;

                        foreach (Appliances w in result)
                        {
                            i++;
                            Console.WriteLine(i + ". Название: " + w.name + "\n   Цена: " + w.price + "\n   Мощность: " + w.power + "\n");
                        }
                        break;
                    }
                case "Цена":
                    {
                        var result = from Appliances in apps
                                     orderby Appliances.price
                                     select Appliances;

                        foreach (Appliances w in result)
                        {
                            i++;
                            Console.WriteLine(i + ". Название: " + w.name + "\n   Цена: " + w.price + "\n   Мощность: " + w.power + "\n");
                        }
                        break;
                    }
                case "Название":
                    {
                        var result = from Appliances in apps
                                     orderby Appliances.name
                                     select Appliances;

                        foreach (Appliances w in result)
                        {
                            i++;
                            Console.WriteLine(i + ". Название: " + w.name + "\n   Цена: " + w.price + "\n   Мощность: " + w.power + "\n");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка: Введен некорректный параметр!");
                        break;
                    }


            }

        }
    }
}