using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTradingSystem
{
    class StockInfo
    {
        public string stockCode;
        public string stockName;
        public StockInfo(string code, string name)
        {
            this.stockCode = code;
            this.stockName = name;
        }
    }
}
