using AxKHOpenAPILib;
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
    public partial class StockSearchUCV : UserControl
    {
        public StockSearchUCV()
        {
            InitializeComponent();
            currentStockCode = "";
            commomcode = new CommomCode();
        }
     //   List<stockInfo> _stockList;
        public string currentStockCode;
        CommomCode commomcode;


        private AxKHOpenAPILib.AxKHOpenAPI _axKHOpenAPI1;
        private FormMain _main;

        public StockSearchUCV(FormMain main, AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1) : this() // 동시에 기본생성자 호출
        {

            _axKHOpenAPI1 = axKHOpenAPI1;
            this._main = main;
            _axKHOpenAPI1.OnReceiveTrData += onReceiveTrData; // 종목검색 이벤트 함수 (비밀번호 입력후 계좌 잔고요청에 성공하면 정보를 받았기 때문에 호출됨)
            _axKHOpenAPI1.OnReceiveRealData += onReceiveRealData;// 실시간 종목검색 이벤트 함수 (실시간만 씀)

            /*          AutoCompleteStringCollection stockcollection = new AutoCompleteStringCollection(); // 자동완성 컬렉션 객체

                      string stockCode = axKHOpenAPI1.GetCodeListByMarket(null);
                      string[] stockCodeArray = stockCode.Split(';');

                      // 종목 정보 리스트 담기
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
            stockTextBox.AutoCompleteCustomSource = commomcode.getStockAutoTextBox(axKHOpenAPI1); // 자동완성 결과 텍스트 박스로 보냄


        }

        private void onReceiveRealData(object sender, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            if (e.sRealType == "주식체결")
            {
                if (e.sRealKey == currentStockCode)
                {
                    // nfid 10은 현재가 . 11. 전일대비 , 12. 등락율 , 15. 거래량
                    long stockPrice = long.Parse(_axKHOpenAPI1.GetCommRealData(currentStockCode, 10)); 
                    long upDown = long.Parse(_axKHOpenAPI1.GetCommRealData(currentStockCode, 11));
                    string upDownRate = _axKHOpenAPI1.GetCommRealData(currentStockCode, 12);
                    long volume = long.Parse(_axKHOpenAPI1.GetCommRealData(currentStockCode, 15));

                    stockPriceLabel.Text = String.Format("{0:#,###}", stockPrice);
                    stockUpDownLabel.Text = String.Format("{0:#,###}", upDown);
                    stockVolumeLabel.Text = String.Format("{0:#,###}", volume);
                    if (upDown == 0)
                    {
                        stockUpDownLabel.Text = "0";
                    }
                    if (volume == 0)
                    {
                        stockVolumeLabel.Text = "0";
                    }
                    stockUpDownRateLabel.Text = upDownRate + "%";
                }
            }
        }
        // 실시간만 씀 (이거 안씀)
        private void onReceiveTrData(object sender, _DKHOpenAPIEvents_OnReceiveTrDataEvent e) 
        {
            if (e.sRQName == "종목정보요청") // 종목정보요청에서 주식체결로 바꿈 
            {
                long stockPrice = long.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim().Replace("-", "")); ;
                string stockName = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                long upDown = long.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim());
                long volume = long.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim());
                string upDownRate = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();

                stockPriceLabel.Text = String.Format("{0:#,###}", stockPrice);

                stockNameLabel.Text = stockName;
                stockUpDownLabel.Text = String.Format("{0:#,###}", upDown);
                stockVolumeLabel.Text = String.Format("{0:#,###}", volume);
                if (upDown == 0)
                {
                    stockUpDownLabel.Text = "0";
                }
                if (volume == 0)
                {
                    stockVolumeLabel.Text = "0";
                }
                stockUpDownRateLabel.Text = upDownRate + "%";
            }

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
