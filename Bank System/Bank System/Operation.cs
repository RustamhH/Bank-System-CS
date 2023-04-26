using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal sealed class Operation
    {

        public readonly Guid Id;
        public readonly DateTime Datetime;
        public string ProcessName { get; set; }

        public Operation() { Id = Guid.NewGuid(); }

        public Operation(DateTime Datetime,string process)
        {
            this.Datetime = Datetime;
            ProcessName = process;
        }

    }
}
