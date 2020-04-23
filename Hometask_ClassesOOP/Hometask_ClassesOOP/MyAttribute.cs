using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask_ClassesOOP
{
    class MyAttribute : Attribute
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
