using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }
        public string Haircolor { get; set; }

        public Person(string name, int age, string hobby, string haircolor)
        {
            Name = name;
            Age = age;
            Hobby = hobby;
            Haircolor = haircolor;
        }

        public void printInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Hei jeg heter {Name}");
            Console.WriteLine($"Jeg er {Age} år gammel.");
            Console.WriteLine($"Jeg liker {Hobby}");
            Console.WriteLine($"jeg har {Haircolor} hår");
        }
    }
}
