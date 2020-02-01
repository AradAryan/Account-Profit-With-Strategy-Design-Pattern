using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    /// <summary>
    /// LastBalanceID,ModifiedDate,ModifiedeTime,AccountNumber,CustomerID,CurrentBalance,CurrentBalanceFlag,FileDate
    /// </summary>
    class Account
    {
        public long LastBalanceID { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedeTime { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerID { get; set; }
        public int CurrentBalanceInt { get; set; }
        public string CurrentBalance { get; set; }
        public bool CurrentBalanceFlag { get; set; }
        public string FileDate { get; set; }
    }
}
