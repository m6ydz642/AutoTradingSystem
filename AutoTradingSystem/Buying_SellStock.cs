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
        private List<Outstanding> _outstandingList;

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
            axKHOpenAPI1.OnReceiveChejanData += AxKHOpenAPI1_OnReceiveChejanData; ;
            stockTextBox.AutoCompleteCustomSource = commomcode.getStockAutoTextBox(axKHOpenAPI1); // 텍스트 박스로 보냄
            addUserInfo();
            accountComboBox.SelectedIndex = 0;

        }

        private void AxKHOpenAPI1_OnReceiveChejanData(object sender, _DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {

            if (e.sGubun == "0")//주문 접수 , 체결시
            {
                alertListBox.Items.Add("계좌번호 : " + _axKHOpenAPI1.GetChejanData(9201) + " | " + " 주문번호 : " + _axKHOpenAPI1.GetChejanData(9203));
                alertListBox.Items.Add("주문상태 : " + _axKHOpenAPI1.GetChejanData(913) + " | " + " 종목명 : " + _axKHOpenAPI1.GetChejanData(302));
                alertListBox.Items.Add("매매구분" + _axKHOpenAPI1.GetChejanData(906) + " | " + " 주문수량 : " + _axKHOpenAPI1.GetChejanData(900));

                string orderTime = _axKHOpenAPI1.GetChejanData(908);
                string orderHour = orderTime[0] + "" + orderTime[1];
                string orderMinute = orderTime[2] + "" + orderTime[3];
                string orderSecond = orderTime[4] + "" + orderTime[5];
                long orderPrice = long.Parse(_axKHOpenAPI1.GetChejanData(901));

                alertListBox.Items.Add("주문/체결시간 : " + orderHour + "시 " + orderMinute + "분 " + orderSecond + "초");
                alertListBox.Items.Add("주문구분 : " + _axKHOpenAPI1.GetChejanData(905));
                alertListBox.Items.Add("주문가격 : " + String.Format("{0:#,###}", orderPrice));
                alertListBox.Items.Add("----------------------------------------------------------");


            }
            else if (e.sGubun == "1")//국내주식 잔고전달
            {
                string stockName = _axKHOpenAPI1.GetChejanData(302);
                long currentPrice = long.Parse(_axKHOpenAPI1.GetChejanData(10).Replace("-", ""));

                string profitRate = _axKHOpenAPI1.GetChejanData(8019);
                long totalBuyingPrice = long.Parse(_axKHOpenAPI1.GetChejanData(932));
                long profitMoney = long.Parse(_axKHOpenAPI1.GetChejanData(950));

                balanceListBox.Items.Add("종목명 : " + stockName + " | 현재 종가 : " + String.Format("{0:#,###}", currentPrice));
                balanceListBox.Items.Add("매입주문금액 : " + String.Format("{0:#,###}", totalBuyingPrice) + " | 금일 실현손익 : " + String.Format("{0:#,###}", profitMoney));
                balanceListBox.Items.Add("금일 실현 손익율 : " + profitRate);
                balanceListBox.Items.Add("----------------------------------------------------------");

            }

        }

        private void onReceiveTrCondition(object sender, _DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            throw new NotImplementedException();
        }

        private void conditionSearch(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            else if (e.sRQName == "실시간미체결요청")
            {
                int count = _axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                _outstandingList = new List<Outstanding>();
                for (int i = 0; i < count; i++)
                {
                    string orderCode = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문번호")).ToString();
                    string stockCode = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    string stockName = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    int orderNumber = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문수량"));
                    int orderPrice = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문가격"));
                    int outstandingNumber = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "미체결수량"));
                    int currentPrice = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Replace("-", ""));
                    string orderGubun = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문구분").Trim();
                    string orderTime = _axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시간").Trim();

                    _outstandingList.Add(new Outstanding(orderCode, stockCode, stockName, orderNumber, String.Format("{0:#,###}", orderPrice), String.Format("{0:#,###}", currentPrice), outstandingNumber, orderGubun, orderTime));

                }
                outstandingDataGridView.DataSource = _outstandingList;
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
            if (sender.Equals(sellButton))
            {
                if (balanceDataGridView.SelectedCells[0] != null)
                {
                    int rowIndex2 = balanceDataGridView.SelectedCells[0].RowIndex;
                    Console.WriteLine(rowIndex2);
                    Console.WriteLine(stockBalanceList[rowIndex2].종목코드);

                }

            }

            string accountCode = accountComboBox.Text;
            int rowIndex = balanceDataGridView.SelectedCells[0].RowIndex;
            int stockQty = int.Parse(balanceDataGridView["수량", rowIndex].Value.ToString());
            string stockCode = balanceDataGridView["종목코드", rowIndex].Value.ToString().Trim().Replace("A", "");

            int stockPrice = int.Parse(priceNumericUpDown.Value.ToString());
            string[] orderCombo = orderComboBox.Text.Split(':');

            _axKHOpenAPI1.SendOrder("종목신규매도", "8289", accountCode, 2, stockCode, stockQty, stockPrice, orderCombo[0], "");
           
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
