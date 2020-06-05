using AufgabePersonen.models;
using System;
using System.Collections.Generic;
using System.IO;

namespace AufgabePersonen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFileContent = File.ReadAllLines("C:\\Users\\DCV\\Desktop\\C#\\AufgabePersonen\\persons.txt");

            List<Person> Persons = new List<Person>();
            foreach (var i in myFileContent)
            {

                Console.WriteLine(i);
                string[] splittedValues = i.Split(";");

                switch (splittedValues[0])
                {
                    case "Hans":
                        Person person1 = new Person(splittedValues[0], Convert.ToInt32(splittedValues[1]), splittedValues[2], "Coder" );
                        Persons.Add(person1);
                        break;
                    case "Helga":
                        Person person2 = new Person(splittedValues[0], Convert.ToInt32(splittedValues[1]), splittedValues[2], "Coder");
                        Persons.Add(person2);
                        break;
                    case "Fritz":
                        Person person3 = new Person(splittedValues[0], Convert.ToInt32(splittedValues[1]), splittedValues[2], "Officer");
                        Persons.Add(person3);
                        break;
                    case "Frida":
                        Person person4 = new Person(splittedValues[0], Convert.ToInt32(splittedValues[1]), splittedValues[2], "Officer");
                        Persons.Add(person4);
                        break;
                }
            }
            List<string> output = new List<string>();
            foreach (Person person in Persons)
            {
                output.Add(person.Name + ";" + person.Age + ";" + person.City + ";" + person.Job);
                Console.WriteLine(person.Name + ";" + person.Age + ";" + person.City + ";" + person.Job);
            }
            File.WriteAllLines("C:\\Users\\DCV\\Desktop\\C#\\AufgabePersonen\\personseddited.txt", output);
        }
    }
}
