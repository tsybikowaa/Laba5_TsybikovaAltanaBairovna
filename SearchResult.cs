using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5Podderzhka
{
    public class SearchResult
    {
        public string Num { get; }
        public string Account { get; }
        public string Type { get; }
        public string Payee { get; }
        public string Amount { get; }
        

        public SearchResult(string num, string account, string type, string payee, string amount)
        {
            Num = num;
            Account = account;
            Type = type;
            Payee = payee;
            Amount = amount;
           
        }
    }
}
