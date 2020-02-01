using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    class Program
    {
        public static string path = @"C:\Users\faranam\Desktop\lastBal.csv";

        static void Main(string[] args)
        {
            Profit profit = new Profit();
            Calculate calculate = new Calculate(10);
            calculate.CalculateBenefits(profit.GetAccounts(path));



            Console.WriteLine("Jobs Done!");
            Console.ReadKey();
        }
    }
}
