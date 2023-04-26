using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal sealed class Client:Person
    {
        public string LiveAddress { get; set; }
        public string WorkAddress { get; set; }

        public List<Credit> Credits { get; set; }

        public Client() { }

        public Client(string name, string surname, int age, double salary, string liveAddress, string workAddress):base(name,surname,age,salary)
        {
            LiveAddress = liveAddress;
            WorkAddress = workAddress;
        }
    }
}
