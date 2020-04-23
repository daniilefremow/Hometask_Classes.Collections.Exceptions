using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask_ClassesOOP
{
    class Washing_Machines : Appliances
    {
        public bool spin_cycle;
        public bool gentle_cycle;

        public Washing_Machines()
        {

        }

        public Washing_Machines(string name, string colour, double price, int power, bool spin_cycle, bool gentle_cycle) : base(name, colour, price, power)
        {
            this.spin_cycle = spin_cycle;
            this.gentle_cycle = gentle_cycle;

        }

        public new void PrintInf()
        {
            base.PrintInf();
            if (gentle_cycle == true)
                Console.WriteLine("   Деликатный режим имеется");
            else
                Console.WriteLine("   Деликатный режим отсутствует");
            if (spin_cycle == true)
                Console.WriteLine("   Режим отжима имеется");
            else
                Console.WriteLine("   Режим отжима отсутствует");
        }
    }
}
