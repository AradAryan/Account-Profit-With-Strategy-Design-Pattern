using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    /// <summary>
    /// Contains Calculate Function and Profit Percent Encapsulated Field and Property.   
    /// </summary>
    class CalculateProfit
    {
        #region Fields & Properties
        /// <summary>
        /// Encapsulation
        /// </summary>
        private static double profit;

        /// <summary>
        /// Get and Set Value For profit Percent Field.
        /// </summary>
        public static double Profit
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
        #endregion

        #region CalculateProfits
        /// <summary>
        /// Constructor for ProfitClass, Profit is Required
        /// </summary>
        public static void CalculateProfits(IEnumerable<IGrouping<string, Account>> list)
        {
            List<string> profitsList = new List<string>();
            int daysInYear = 36500;
            double finalProfit = 0;
            string currnetKey;
            int balance = 0;
            int count = 0;
            foreach (var item in list)
            {
                currnetKey = item.Key;
                if (currnetKey.StartsWith("02"))
                    Profit = 12;
                if (currnetKey.StartsWith("03"))
                    Profit = 13.5;
                if (currnetKey.StartsWith("04"))
                    Profit = 10;
                var temp = 
                    item.ToList().GroupBy
                    (account => account.CurrentBalance);
                foreach (var values in temp)
                {
                    count = 
                        values.Key.Count();
                    balance = 
                        int.Parse(values.Key);
                    for (int i = 1387; i < 1450; i += 4)
                    {
                        if (values.FirstOrDefault()
                            .FileDate.StartsWith(i.ToString()))
                        {
                            daysInYear = 36600;
                            break;
                        }
                    }
                    finalProfit +=
                        (count * profit * balance) / daysInYear;
                }
                profitsList.Add
                    ($"Account Number: {currnetKey}, Profit: {finalProfit.ToString()}");
            }
            //////output
            foreach (var item in profitsList)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
    }
}
