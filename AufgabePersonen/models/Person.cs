using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabePersonen.models
{
    public class Person
    {
        public string Name, City, Job;
        public int Age;
        public Person(string Name, int Age, string City, string Job)
        {
            this.Name = Name;
            this.Age = Age;
            this.City = City;
            this.Job = Job;
        }




    }
}
