using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal abstract class Person
    {

        // fields & properties

        private int _age;
        private double _salary;

        public readonly Guid Id;
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 18) throw new Exception("Person must be at least 18");
                _age = value;
            }
        }
        
        public double Salary
        {
            get => _salary;
            set
            {
                if (value < 100) throw new Exception("Person should get at least 100 $ salary");
                _salary = value;
            }
        }


        // Constructors

        public Person()
        {
            Id = Guid.NewGuid();
        }

        public Person(string name, string surname, int age, double salary):this()
        {
            Age = age;
            Salary = salary;
            Name = name;
            Surname = surname;
        }




    }
}
