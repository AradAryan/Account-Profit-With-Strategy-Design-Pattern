using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Profit_With_Strategy_Design_Pattern
{
    class Account
    {
        public int LastBalanceID { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedeTime { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerID { get; set; }
        public string ModiCurrentBalancefiedDate { get; set; }
        public int CurrentBalance { get; set; }
        public char CurrentBalanceFlag { get; set; }
        public string FileDate { get; set; }
    }
}
//LastBalanceID,ModifiedDate,ModifiedeTime,AccountNumber,CustomerID,CurrentBalance,CurrentBalanceFlag,FileDate