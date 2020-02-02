using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    /// <summary>
    /// Contains Calculate Function and Profit Percent Encapsulated Field and Property.   
    /// </summary>
    class CalculateProfit04
    {
        #region Fields & Properties
        /// <summary>
        /// Encapsulation
        /// </summary>
        private double profit;

        /// <summary>
        /// Get and Set Value For profit Percent Field.
        /// </summary>
        public double Profit
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

        #region Constructor
        /// <summary>
        /// Constructor for ProfitClass, Profit is Required
        /// </summary>
        public CalculateProfit04(double profitPercent)
        {
            Profit = profitPercent;
        }
        #endregion

        #region CalculateProfits
        /// <summary>
        /// Get a list of accounts and write Profit at output
        /// </summary>
        public void CalculateProfits(IEnumerable<IGrouping<string, Account>> list)
        {
            List<string> profitsList = new List<string>();
            int daysInYear = 36500;
            double finalProfit = 0;
            string currnetKey;
            int balance = 0;
            int count = 0;
            var temp =
                list.Where(currnet => currnet.Key.StartsWith("04")).ToList();

            foreach (var item in temp)
            {
                var groupedList = item.ToList().GroupBy(account => account.CurrentBalance);
                {
                    currnetKey = item.Key;
                    foreach (var values in groupedList)
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
                            (count * Profit * balance) / daysInYear;
                    }
                    profitsList.Add
                        ($"Account Number: {currnetKey}, Profit: {finalProfit.ToString()}");
                }
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
