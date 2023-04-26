using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal sealed class Credit
    {
        private int _months;
        private double _amount;
        private double _percent;
        private double _payment;

        public readonly Guid Id;

        public double Amount { get=>_amount; set 
            {
                if(value<0) throw new Exception("Invalid Amount");
                _amount = value;
            } 
        }
        public double Percent { get=>_percent; set 
            {
                if (value < 0) throw new Exception("Invalid Percentage");
                _percent = value;
            }
        }
        public double Payment { get=>_payment; set
            {
                if (value < 0) throw new Exception("Invalid Payment");
                _payment = value;
            } 
        }
        public int Months { get=>_months; set 
            {
                if (value < 1) throw new Exception("Invalid Month");
                _months = value;
            } 
        }

        public Credit() { Id = Guid.NewGuid(); }

        public Credit(int months,double amount,double percent,double payment):this() {
            Months = months;
            Amount = amount;
            Percent = percent;
            Payment = payment;
        }


        public override string ToString()
        {
            return $"Amount {Amount} Payment {Payment} Months {Months} Percent {Percent}\n";
        }

    }
}
