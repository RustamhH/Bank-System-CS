using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal sealed class CEO : Person, IOrganize, IPosition
    {
        // Field
        public string Position { get; set; }



        // Methods

        public void Control()
        {
            Console.WriteLine("Ceo controlled workers and managers...");
        }

        public void DecreasePercentage(out double per,double newper)
        {
            per= newper;
        }

        public void MakeMeeting()
        {
            Console.WriteLine("Ceo made meeting...");
        }
        public void Organize()
        {
            Console.WriteLine("Ceo organized some events...");
        }

        public CEO() { }

        public CEO(string name, string surname, int age, double salary,string position):base(name,surname, age, salary)
        {
            Position = position;
        }
    }
}
