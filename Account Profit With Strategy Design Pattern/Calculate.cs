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
        public Calculate(int ProfitPercent)
        {
            Profit = ProfitPercent;
        }

        public void CalculateBenefits(List<Account> list)
        {
            Console.WriteLine(list.Count);
        }
    }
}
