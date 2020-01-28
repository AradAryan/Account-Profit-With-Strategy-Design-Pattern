using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    class Profit
    {
        /// <summary>
        /// Caculate and Returns Benefits.
        /// </summary>
        /// <returns></returns>
        public void Benefits(List<Account> accounts)
        {
            var accounts02 = accounts.GroupBy(account => account.AccountNumber);
        }

        /// <summary>
        /// Returns a List<ProfitStartegy> of Accounts Informations From CSV File
        /// </summary>
        /// <param name="path"> CSV File Address </param>
        /// <returns> List<ProfitStrategy> </returns>
        public List<Account> GetAccounts(string path)
        {
            List<Account> list = new List<Account>();

            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                streamReader.ReadLine().Split(',');
                string[] context = File.ReadAllLines(path);

                for (int i = 1; i < context.Length; i++)
                {
                    Account account = new Account();
                    var values = context[i].Split(',');
                    account.LastBalanceID = long.Parse(values[0]);
                    account.ModifiedDate = values[1];
                    account.ModifiedeTime = values[2];
                    account.AccountNumber = values[3];
                    account.CustomerID = values[4];
                    account.CurrentBalance = values[5];
                    account.CurrentBalanceInt = int.Parse(values[5]);
                    if (values[6] == "+")
                    {
                        account.CurrentBalanceFlag = true;
                    }
                    else
                        account.CurrentBalanceFlag = true;
                    account.FileDate = values[7];
                    list.Add(account);
                    //LastBalanceID,ModifiedDate,ModifiedeTime,AccountNumber,CustomerID,CurrentBalance,CurrentBalanceFlag,FileDate
                }
            }
            return list;
        }
    }
}
