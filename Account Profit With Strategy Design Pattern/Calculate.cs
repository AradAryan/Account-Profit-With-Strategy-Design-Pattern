using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    class Calculate
    {

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


        /// <summary>
        /// Constructor for ProfitClass, Profit is Required
        /// </summary>
        public Calculate(int ProfitPercent)
        {
            Profit = ProfitPercent;
        }

        public void CalculateBenefits(IEnumerable<IGrouping<string, Account>> list)
        {
            List<string> profitsList = new List<string>();
            string currnetKey;
            int count = 0;
            int balance = 0;
            double finalProfit = 0;
            int daysInYear = 36500;
            //1399
            foreach (var item in list)
            {
                currnetKey = item.Key;

                if (currnetKey.StartsWith("02"))
                    Profit = 12;

                if (currnetKey.StartsWith("03"))
                    Profit = 13.5;

                if (currnetKey.StartsWith("04"))
                    Profit = 10;

                var temp = item.ToList().GroupBy(account => account.CurrentBalance);

                foreach (var values in temp)
                {
                    count = values.Key.Count();
                    balance = int.Parse(values.Key);

                    for (int i = 1387; i < 1450; i += 4)
                    {
                        if (values.FirstOrDefault().FileDate.StartsWith(i.ToString()))
                        {
                            daysInYear = 36600;
                            break;
                        }
                    }

                    finalProfit += (count * profit * balance) / daysInYear;
                }

                profitsList.Add(currnetKey + "  =  " + finalProfit.ToString());
            }

            //////output
            foreach (var item in profitsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
