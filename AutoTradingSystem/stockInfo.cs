using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTradingSystem
{
    class stockInfo
    {
        public string stockCode;
        public string stockName;
        public stockInfo(string code, string name)
        {
            this.stockCode = code;
            this.stockName = name;
        }
    }
}
