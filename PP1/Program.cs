using System;

namespace PP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool app = true;
            List<Person> People = new List<Person>();
            Person person1 = new Person("John", 30, "klatre", "grå");
            People.Add(person1);
            while (app == true)
            {
                Console.WriteLine("Hva vil du gjøre?");
                Console.WriteLine("    1. Se alle brukere.");
                Console.WriteLine("    2. Registrere ny bruker.");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("Velg en bruker");

                    for (int i = 0; i < People.Count; i++)
                    {
                        Console.WriteLine($"    {i}.{People[i].Name}");
                    }
                    Console.WriteLine("write the name of the user you want to see"); 
                    string userinput = Console.ReadLine();

                    foreach (var person in People)
                    {
                        if (userinput == person.Name)
                        {
                            person.printInfo();
                        }
                    }
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Hva heter du?");
                    string name = Console.ReadLine();

                    Console.WriteLine("Hvor gammel er du?");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hvilken hårfarge har du?");
                    string hairColor = Console.ReadLine();

                    Console.WriteLine("Hvilken hobby har du?");
                    string hobby = Console.ReadLine();

                    Person person2 = new Person(name, age, hobby, hairColor);

                    People.Add(person2);
                    Thread.Sleep(1000);
                    Console.WriteLine("User added");
                }

                Console.WriteLine();
            }
        }
    }
}
