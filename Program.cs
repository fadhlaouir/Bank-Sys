using System;
using BankSys.Account;
using BankSys.Client;


namespace BankSys
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Client<AbstractAccount<int,int,int>> client = new Client<AbstractAccount<int,int,int>>(1000, "test");
           
            Console.WriteLine(client.CIN);

            Console.WriteLine("Welcome");
            Console.ReadLine();


        }
    }
}
