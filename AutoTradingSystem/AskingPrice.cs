using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTradingSystem
{
    public partial class AskingPrice : UserControl
    {
        // List<stockInfo> _stockList;
        public string currentStockCode;
        CommomCode commomcode;

        private AxKHOpenAPILib.AxKHOpenAPI _axKHOpenAPI1;
        public AskingPrice()
        {
            InitializeComponent();
            commomcode = new CommomCode();
        }

        public AskingPrice(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1) : this()
        {
            _axKHOpenAPI1 = axKHOpenAPI1;

           /* string stockCode = axKHOpenAPI1.GetCodeListByMarket(null);
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
            stockTextBox.AutoCompleteCustomSource = stockcollection; // 텍스트 박스로 보냄
           */
            stockTextBox.AutoCompleteCustomSource = commomcode.getStockAutoTextBox(axKHOpenAPI1); // 텍스트 박스로 보냄
        }


        private void stockSearchButton_Click(object sender, EventArgs e)
        {
            string searchStock = stockTextBox.Text;
            int index = commomcode._stockList.FindIndex(o => o.stockName == searchStock);
            if (index == -1)
                MessageBox.Show("자동완성 오류 종목명을 정확히 입력해주세요", "아쉽게도 자동완성오류");
            else
            {
                string stockCode = commomcode._stockList[index].stockCode;
                currentStockCode = stockCode; // 실시간 코드 변수에 추가
                // string stockCode = "005930";
                _axKHOpenAPI1.SetInputValue("종목코드", stockCode);
                _axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");
            }

        }
    }
}
