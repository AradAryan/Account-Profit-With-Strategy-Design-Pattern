using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    class ProfitStrategy
    {
        /// <summary>
        /// Encapsulation
        /// </summary>
        private int profit;

        /// <summary>
        /// Get and Set Value For profit Percent Field.
        /// </summary>
        public int Profit
        {
            get
            {
                return profit;
            }
            set
            {
                if (0 <= value && value <= 100)
                    profit = value;
                else
                    Console.WriteLine("Error! Profit is Less than 0 or More than 100.");
            }
        }

        /// <summary>
        /// Constructor for ProfitClass, Profit is Required
        /// </summary>
        /// <param name="ProfitPercent">
        /// Account Profit Percent, Between 0-100;
        /// </param>
        public ProfitStrategy(int ProfitPercent)
        {
            Profit = ProfitPercent;
        }

        /// <summary>
        /// Caculate and Returns Benefits.
        /// </summary>
        /// <returns></returns>
        public int CalculateBenefit()
        {


            return 1;
        }

        /// <summary>
        /// Returns a List<ProfitStartegy> of Accounts Informations From CSV File
        /// </summary>
        /// <param name="path"> CSV File Address </param>
        /// <returns> List<ProfitStrategy> </returns>
        public List<ProfitStrategy> GetAccounts(string path)
        {
            Account account = new Account();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                streamReader.ReadLine().Split(',');
                string[] context = File.ReadAllLines(path);
                foreach (var item in context)
                {
                    var values = item.Split(',');

                    account.LastBalanceID = int.Parse(values[0]);
                    account.ModifiedDate = values[1];
                }

            }

            return null;

        }
    }
}
