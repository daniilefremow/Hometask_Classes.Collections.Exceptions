using System;

namespace Hometask_ClassesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Washing_Machines LG101 = new Washing_Machines("LG101", "Серый", 5999.99d, 2000, true, false);
            Console.WriteLine("Стиральная машинка №1:");
            LG101.PrintInf();

            Washing_Machines Polaris333 = new Washing_Machines("Polaris333", "Белый", 13399.99d, 3500, true, true);
            Console.WriteLine("\nСтиральная машинка №2:");
            Polaris333.PrintInf();

            Vacuum_Cleaners Samsung201 = new Vacuum_Cleaners("Samsung201", "Красный", 4399.99d, 1000, false, "Автомобиль");
            Console.WriteLine("\nПылесос №1:");
            Samsung201.PrintInf();

            Vacuum_Cleaners LG390 = new Vacuum_Cleaners("LG390", "Черный", 21099.99d, 4000, true, "Квартира");
            Console.WriteLine("\nПылесос №2:");
            LG390.PrintInf();


        }
    }
}
