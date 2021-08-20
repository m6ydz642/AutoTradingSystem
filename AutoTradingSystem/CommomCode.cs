using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTradingSystem
{
    class CommomCode
    {
        public List<stockInfo> _stockList;
       
        public AutoCompleteStringCollection getStockAutoTextBox(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1)
        {
            string stockCode = axKHOpenAPI1.GetCodeListByMarket(null);
            string[] stockCodeArray = stockCode.Split(';');

            // 종목 정보 리스트 담기
            AutoCompleteStringCollection stockcollection = new AutoCompleteStringCollection(); // 자동완성 컬렉션 객체
            _stockList = new List<stockInfo>(); // 전역객체로 보냄
            for (int i = 0; i < stockCodeArray.Length; i++)
            {
                _stockList.Add(new stockInfo(stockCodeArray[i], axKHOpenAPI1.GetMasterCodeName(stockCodeArray[i])));
            }
            for (int i = 0; i < _stockList.Count; i++)
            {
                stockcollection.Add(_stockList[i].stockName);
            }
            return stockcollection;
        }
    }
}
