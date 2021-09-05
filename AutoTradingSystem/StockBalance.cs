using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTradingSystem
{
    class StockBalance
    {
        public string 종목코드 { get; set; }
        public string 종목명 { get; set; }
        public long 수량 { get; set; }
        public string 매수금 { get; set; }
        public string 현재가 { get; set; }
        public long 평가손익 { get; set; }
        public string 수익률 { get; set; }

        public StockBalance() { }

        public StockBalance(string 종목번호, string 종목명, long 수량, string 매수금, string 현재가, long 평가손익, string 수익률)
        {
            this.종목코드 = 종목번호;
            this.종목명 = 종목명;
            this.수량 = 수량;
            this.매수금 = 매수금;
            this.현재가 = 현재가;
            this.평가손익 = 평가손익;
            this.수익률 = 수익률;
        }

    }
}
