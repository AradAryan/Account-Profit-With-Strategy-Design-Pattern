using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    class Program
    {
        #region Fields
        /// <summary>
        /// CSV File Path
        /// </summary>
        public static string path = @"C:\Users\faranam\Desktop\lastBal.csv";
        #endregion

        #region Functions
        /// <summary>
        /// Main Function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var profit02 =
                new CalculateProfit02(12);
            var profit03 =
                new CalculateProfit03(13.5);
            var profit04 =
                new CalculateProfit04(14);
            profit02.CalculateProfits
                (GetAccountsList.GetAccounts(path));
            profit03.CalculateProfits
                (GetAccountsList.GetAccounts(path));
            profit04.CalculateProfits
                (GetAccountsList.GetAccounts(path));

            ///Ending
            Console.WriteLine("Jobs Done!");
            Console.ReadKey();
        }
        #endregion
    }
}
