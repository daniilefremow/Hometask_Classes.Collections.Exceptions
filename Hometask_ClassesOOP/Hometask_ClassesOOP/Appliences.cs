using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask_ClassesOOP
{
    class Appliances
    {
        public string name;
        public string colour;
        public double price;
        public int power;

        public Appliances()
        {

        }

        public Appliances(string name, string colour, double price, int power)
        {
            this.name = name;
            this.colour = colour;
            this.price = price;
            this.power = power;
        }
        public void PrintInf()
        {
            Console.WriteLine("   Название: {0}\n   Цвет: {1}\n   Цена: {2} рублей\n   Мощность: {3} Вт", name, colour, price, power);
        }
    }
}
