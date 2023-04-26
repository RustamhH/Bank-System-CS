using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal sealed class Bank
    {
        private double _budget;
        private double _profit;
        public string Name { get; set; }

        public List<CEO> CEOs { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Client> Clients { get; set; }
        public List<Worker> Workers { get; set; }



        public double Budget
        {
            get => _budget;
            set
            {
                if (value < 0) throw new Exception("Invalid Budget");
                _budget = value;
            }
        }
        
        public double Profit
        {
            get => _profit;
            set
            {
                if (value < 0) throw new Exception("Invalid Profit");
                _profit = value;
            }
        }


        public void ShowClientCredit(string fullName)
        {
            foreach (var item in Clients)
            {
                if(item.Name+" "+item.Surname==fullName)
                {
                    foreach (var credits in item.Credits)
                    {
                        Console.WriteLine(credits);
                    }
                }
            }
            Console.WriteLine("Client Not Found");
        }


        public void CalculateProfit()
        {
            double profit = 0;
            foreach (var item in Clients)
            {
                foreach (var item1 in item.Credits)
                {
                    profit += item1.Payment;
                }
            }
            Profit = profit;
        }
        



        public void PayCredit(Client cl,Credit cr,double pay)
        {
            foreach (var item in cl.Credits)
            {
                if(item==cr)
                {
                    item.Payment += pay;
                    item.Amount -= pay;
                    if(item.Amount==0)
                    {
                        cl.Credits.Remove(item);
                    }

                }
            }
           
        }

        public void ShowAllCredits()
        {
            foreach (var item in Clients)
            {
                foreach (var item1 in item.Credits)
                {
                    Console.WriteLine(item1);
                }
            }
        }


        public Bank() { }

        public Bank(string name,double budget)
        {
            Name = name;
            Budget = budget;
        }



        



    }
}
