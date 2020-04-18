using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask_ClassesOOP
{
    class Vacuum_Cleaners : Appliances
    {
        public bool wet_cleaning;
        public string purpose;

        public Vacuum_Cleaners(string name, string colour, double price, int power, bool wet_cleaning, string purpose) : base(name, colour, price, power)
        {
            this.wet_cleaning = wet_cleaning;
            this.purpose = purpose;

        }

        public new void PrintInf()
        {
            base.PrintInf();
            if (wet_cleaning == true)
                Console.WriteLine("Режим влажной уборки имеется");
            else
                Console.WriteLine("Режим влажной уборки отсутствует");
            Console.WriteLine("Что убирает: {0}", purpose);
        }
    }
}
