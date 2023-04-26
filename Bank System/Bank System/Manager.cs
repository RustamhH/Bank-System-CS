using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Manager:Person,IOrganize,IPosition
    {
        public string Position { get; set; }
        public void Organize()
        {
            Console.WriteLine("Manager organized some events....");
        }

        public double CalculateSalaries(List<Worker>workers,List<CEO>ceos,List<Manager>managers)
        {
            double total=0;
            foreach (var item in workers)
            {
                total += item.Salary;
            }foreach (var item in ceos)
            {
                total += item.Salary;
            }foreach (var item in managers)
            {
                total += item.Salary;
            }
            return total;
        }

        public Manager() { }

        public Manager(string name, string surname, int age, double salary, string position) : base(name, surname, age, salary)
        {
            Position = position;
        }

    }
}
