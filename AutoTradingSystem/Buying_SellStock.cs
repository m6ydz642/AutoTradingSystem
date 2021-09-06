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
    public partial class Buying_SellStock : UserControl
    {
        private string currentStockCode;
        CommomCode commomcode;
        private long _buyingLimit;
        List<StockInfo> stockList;
        List<StockBalance> stockBalanceList;
        public string _accountNumber = string.Empty;


        private AxKHOpenAPILib.AxKHOpenAPI _axKHOpenAPI1;
        public Buying_SellStock()
        {
            InitializeComponent();
            commomcode = new CommomCode();
        }

        public Buying_SellStock(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1) : this()
        {
            _axKHOpenAPI1 = axKHOpenAPI1;

          //  axKHOpenAPI1.OnEventConnect += onEventConnect; // 이벤트 함수 호출
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
            balanceDataGridView.SelectionChanged += conditionSearch; //조건식 검색
            axKHOpenAPI1.OnReceiveTrCondition += onReceiveTrCondition; //조건식 검색결과

            stockTextBox.AutoCompleteCustomSource = commomcode.getStockAutoTextBox(axKHOpenAPI1); // 텍스트 박스로 보냄
            addUserInfo();
            accountComboBox.SelectedIndex = 0;

        }

        private void onReceiveTrCondition(object sender, _DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
          //  throw new NotImplementedException();
        }

        private void conditionSearch(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void addUserInfo()
        {
            orderComboBox.Items.Add("00:지정가".ToString());
            orderComboBox.Items.Add("03:시장가".ToString());

            for (int i = 0; i < UserInfoModel.accountlist.Length; i++)
            {
                accountComboBox.Items.Add(UserInfoModel.accountlist[i]);
            }
        }

        public void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            // 어짜피 로그인해야 넘어올 화면이라 별도의 함수 만들어서 호출 함
            /* if (e.nErrCode == 0)
             {
                 orderComboBox.Items.Add("00:지정가".ToString());
                 orderComboBox.Items.Add("03:시장가".ToString());

                 string accountList = _axKHOpenAPI1.GetLoginInfo("ACCLIST");
                 string[] accountArray = accountList.Split(';');
                 for (int i = 0; i < accountArray.Length; i++)
                 {
                     accountComboBox.Items.Add(accountArray[i]);
                 }
             }*/
        }

        private void stockSearchButton_Click(object sender, EventArgs e)
        {
            string stockText = stockTextBox.Text;
            if (stockText != "")
            {
                //int index = commomcode._stockList.FindIndex(o => o.stockName == stockText);
                int index = commomcode.getFindStockIndex(stockTextBox.Text);
                if (index != -1)
                {
                    string stockCode = commomcode._stockList[index].stockCode;
                    _axKHOpenAPI1.SetInputValue("종목코드", stockCode);
                    _axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");
                }
                else
                {
                    MessageBox.Show("종목을 찾을수 없습니다");
                }
            }
            else
            {
                MessageBox.Show("종목명을 입력해주세요");
            }

        }

        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "종목정보요청")
            {
                string stockPrice = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가");
                priceNumericUpDown.Value = long.Parse(stockPrice.Replace("-", ""));
            }
            else if (e.sRQName == "계좌평가현황요청")
            {
                int count = _axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                stockBalanceList = new List<StockBalance>();
                for (int i = 0; i < count; i++)
                {
                    string stockCode = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").TrimStart('0');
                    string stockName = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    long number = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량") == "" ?  0: long.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                    long buyingMoney = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입금액") == "" ? 0 : long.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입금액"));
                    long currentPrice = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가") == "" ? 0 : long.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Replace("-", ""));
                    long estimatedProfit = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익금액") == "" ? 0: long.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익금액"));
                    double estimatedProfitRate = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익율") == "" ? 0: double.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익율"));


                    stockBalanceList.Add(new StockBalance(stockCode, stockName, number, String.Format("{0:#,###}", buyingMoney), String.Format("{0:#,###}", currentPrice), estimatedProfit, String.Format("{0:f2}", estimatedProfitRate)));
                }
                balanceDataGridView.DataSource = stockBalanceList;
            }

        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (sender.Equals(buyButton))
            {
                if (stockTextBox.Text.Length > 0 && accountComboBox.Text.Length > 0)
                {
                    //string stockText = stockTextBox.Text;
                    //int index = commomcode._stockList.FindIndex(o => o.stockName == stockText);
                    int index = commomcode.getFindStockIndex(stockTextBox.Text);
                    if (index != -1)
                    {
                        string orderCode = commomcode._stockList[index].stockCode;
                        string accountCode = accountComboBox.Text;
                        int stockQty = int.Parse(numberNumericUpDown.Value.ToString());
                        int stockPrice = int.Parse(priceNumericUpDown.Value.ToString());
                        string[] orderCombo = orderComboBox.Text.Split(':');

                        _axKHOpenAPI1.SendOrder("종목신규매수", "8249", accountCode, 1, orderCode, stockQty, stockPrice, orderCombo[0], "");
                    }
                    else
                    {
                        MessageBox.Show("종목을 찾을수 없습니다");
                    }
                }
            }

        }

        private void sellButton_Click(object sender, EventArgs e)
        {

        }


        private void setLimitButton_Click(object sender, EventArgs e)
        {
           
            if (long.Parse(limitNumericUpDown.Value.ToString()) > 0)
            {
                _buyingLimit = long.Parse(limitNumericUpDown.Value.ToString());
                Console.WriteLine(_buyingLimit);
                MessageBox.Show("금액제한 설정완료" + _buyingLimit + "원");
            }
            else
            {
                MessageBox.Show("매수제한 금액을 입력하세요");
            }
        }

        private void clearLimitButton_Click(object sender, EventArgs e)
        {
          
            if (long.Parse(limitNumericUpDown.Value.ToString()) > 0)
            {
                // _buyingLimit = limitNumericUpDown.Value.ToString() == "" ? 0: long.Parse(limitNumericUpDown.Value.ToString());
                _buyingLimit = 0;
                Console.WriteLine(_buyingLimit);
                MessageBox.Show("매수금액제한 해제 완료 " + _buyingLimit + "원");

            }
        }

        private void balanceCheckButton_Click(object sender, EventArgs e)
        {
            _accountNumber = accountComboBox.Text;
            string password = string.Empty;

            _axKHOpenAPI1.SetInputValue("계좌번호", _accountNumber);
            _axKHOpenAPI1.SetInputValue("비밀번호", password);
            _axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
            _axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            _axKHOpenAPI1.CommRqData("계좌평가현황요청", "opw00004", 0, "0004");
        }
    }
}
