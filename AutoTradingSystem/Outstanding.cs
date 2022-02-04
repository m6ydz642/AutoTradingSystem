using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTradingSystem
{
    public class Outstanding
    {
        string orderCode { get; set; }
        string stockCode { get; set; }
        string stockName { get; set; }
        int orderNumber { get; set; }
        string orderPrice { get; set; } // int에서 스트링 (호출 되는 곳에서 string format으로 변환 함)
        int outstandingNumber { get; set; }
        string currentPrice { get; set; } // int 에서 스트링
        string orderGubun { get; set; }
        string orderTime { get; set; }

        public Outstanding(string orderCode, string stockCode, string stockName, int orderNumber, string orderPrice,
                       string currentPrice, int outstandingNumber,  string orderGubun, string orderTime)
        {
            this.orderCode = orderCode;
            this.stockCode = stockCode;
            this.stockName = stockName;
            this.orderNumber = orderNumber;
            this.orderPrice = orderPrice;
            this.outstandingNumber = outstandingNumber;
            this.currentPrice = currentPrice;
            this.orderGubun = orderGubun;
            this.orderTime = orderTime;
        }

    }
}
