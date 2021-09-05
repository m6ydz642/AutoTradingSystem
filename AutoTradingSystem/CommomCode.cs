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
        public List<StockInfo> _stockList;
       
        public AutoCompleteStringCollection getStockAutoTextBox(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1)
        {
            string stockCode = axKHOpenAPI1.GetCodeListByMarket(null);
            string[] stockCodeArray = stockCode.Split(';');

            // 종목 정보 리스트 담기
            AutoCompleteStringCollection stockcollection = new AutoCompleteStringCollection(); // 자동완성 컬렉션 객체
            _stockList = new List<StockInfo>(); // 전역객체로 보냄
            for (int i = 0; i < stockCodeArray.Length; i++)
            {
                _stockList.Add(new StockInfo(stockCodeArray[i], axKHOpenAPI1.GetMasterCodeName(stockCodeArray[i])));
            }
            for (int i = 0; i < _stockList.Count; i++)
            {
                stockcollection.Add(_stockList[i].stockName);
            }
            return stockcollection;
        }

        public int getFindStockIndex(string stockText) 
        {
            int index = _stockList.FindIndex(o => o.stockName == stockText);
            return index;
        }
    }
}
