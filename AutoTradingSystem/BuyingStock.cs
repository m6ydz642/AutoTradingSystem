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
    public partial class BuyingStock : UserControl
    {
        public string currentStockCode;
        CommomCode commomcode;

        private AxKHOpenAPILib.AxKHOpenAPI _axKHOpenAPI1;
        public BuyingStock()
        {
            InitializeComponent();
            commomcode = new CommomCode();
        }

        public BuyingStock(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1) : this()
        {
            _axKHOpenAPI1 = axKHOpenAPI1;

          //  axKHOpenAPI1.OnEventConnect += onEventConnect; // 이벤트 함수 호출
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;

            stockTextBox.AutoCompleteCustomSource = commomcode.getStockAutoTextBox(axKHOpenAPI1); // 텍스트 박스로 보냄
            addUserInfo();

        }

        private void addUserInfo()
        {
            orderComboBox.Items.Add("00:지정가".ToString());
            orderComboBox.Items.Add("03:시장가".ToString());

            for (int i = 0; i < Model.accountlist.Length; i++)
            {
                accountComboBox.Items.Add(Model.accountlist[i]);
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
    }
}
