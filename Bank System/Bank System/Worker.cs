using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal sealed class Worker:Person,IPosition
    {
        // Fields & properties
        public string Position { get; set; }
        public readonly DateTime StartTime;
        public readonly DateTime EndTime;

        public List<Operation> Operations { get; set; }

        public void AddOperation(Operation operation)
        {
            Operations.Add(operation);
        }


        // Constructors
        public Worker() {
        
            Operations = new List<Operation>();
        }

        public Worker(string name, string surname, int age, double salary, string position,DateTime start,DateTime end) : base(name, surname, age, salary)
        {
            Position = position;
            StartTime = start;
            EndTime = end;
        }
    }
}
