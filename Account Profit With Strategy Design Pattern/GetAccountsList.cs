using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    /// <summary>
    /// Contain a Function That, Get Path Of CSV File And Return a List<IEnumerable<IGrouping<string, Account>>.
    /// </summary>
    class GetAccountsList
    {
        /// <summary>
        /// Returns a List<Account> of Accounts Informations From CSV File
        /// </summary>
        /// <param name="path"> CSV File Address </param>
        /// <returns> List<Account> </returns>
        public static IEnumerable<IGrouping<string, Account>> GetAccounts(string path)
        {
            List<Account> list =
                new List<Account>();
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                streamReader.ReadLine().Split(',');
                string[] context =  
                    File.ReadAllLines(path);
                for (int i = 1; i < context.Length; i++)
                {
                    Account account = new Account();
                    var values =
                        context[i].Split(',');
                    account.LastBalanceID = long.Parse(values[0]);
                    account.ModifiedDate = values[1];
                    account.ModifiedeTime = values[2];
                    account.AccountNumber = values[3];
                    account.CustomerID = values[4];
                    account.CurrentBalance = values[5];
                    ///[6]
                    account.CurrentBalanceInt = int.Parse(values[5]);
                    if (values[6] == "+")
                    {
                        account.CurrentBalanceFlag = true;
                    }
                    else
                        account.CurrentBalanceFlag = true;
                    ///[6]
                    account.FileDate = values[7];
                    list.Add(account);
                }
            }
            var output = 
                list.GroupBy
                (account => account.AccountNumber);
            return output;
        }
    }
}
