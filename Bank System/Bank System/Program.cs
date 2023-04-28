namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CEO ceo = new CEO("Rustem", "Hesenli", 25, 9000, "ceo");
                Worker worker = new Worker("Ibrahim", "Asadov", 18, 5000, "worker", new DateTime(2011, 6, 22), new DateTime(2025, 8, 23));
                Worker worker2 = new Worker("Kenan", "Hesenov", 45, 3000, "worker", new DateTime(2008, 6, 22), new DateTime(2033, 11, 23));
                Manager manager = new Manager("Hesen", "Abdullazade", 19, 10000, "manager");
                Client client = new Client("Merac", "Omarov", 23, 6000, "Nerimanov", "Dernegul");




                worker.AddOperation(new Operation(DateTime.Now, "Kredit verme"));
                worker.AddOperation(new Operation(DateTime.Now, "Depozit"));
                worker2.AddOperation(new Operation(DateTime.Now, "Hesabin yaradilmasi"));
                worker2.AddOperation(new Operation(DateTime.Now, "Hesabin artirilmasi"));

                Credit credit = new Credit(54, 8888, 34, 500);
                client.Credits.Add(credit);


                Bank bank = new Bank("KapitalBank", 2000000);
                bank.CEOs.Add(ceo);
                bank.Managers.Add(manager);
                bank.Clients.Add(client);
                bank.Workers.Add(worker);
                bank.Workers.Add(worker2);


                ceo.MakeMeeting();
                ceo.Organize();
                ceo.Control();
                double per = client.Credits[0].Percent;
                ceo.DecreasePercentage(out per, 12);


                manager.Organize();
                Console.WriteLine(manager.CalculateSalaries(bank.Workers, bank.CEOs, bank.Managers));

                bank.CalculateProfit();
                bank.ShowClientCredit("Merac Omarov");
                bank.ShowAllCredits();


                bank.PayCredit(client, credit, 100);
            }
            catch (Exception Ex) { 
                Console.WriteLine(Ex.Message);
                Console.ReadKey(true);
            }

        }
    }
}