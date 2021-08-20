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

            priceListBox.DrawItem += ListBox_DrawItem;
            priceListBox.DrawMode = DrawMode.OwnerDrawVariable;

            priceListBox.ItemHeight = priceListBox.Height / 20;

            volumeListBox.DrawItem += ListBox_DrawItem;
            volumeListBox.DrawMode = DrawMode.OwnerDrawVariable;
            volumeListBox.ItemHeight = volumeListBox.Height / 20;

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
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
            axKHOpenAPI1.OnReceiveRealData += onReceiveRealData;
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
                
     /*           _axKHOpenAPI1.SetInputValue("종목코드", stockCode);
                _axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");*/
                _axKHOpenAPI1.SetInputValue("종목코드", stockCode);
                _axKHOpenAPI1.CommRqData("주식호가", "opt10004", 0, "5001"); // 화면번호는 달라야 됨
            }

        }
        private void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "주식호가")
            {
                priceListBox.Items.Clear();
                volumeListBox.Items.Clear();
                for (int i = 0; i < 9; i++)
                {
                    int 차선호가 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매도" + (10 - i) + "차선호가"));
                    priceListBox.Items.Add(차선호가 + " / " + (10 - i) + "차선");

                    if (i == 4)
                    {
                        int 차선잔량 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매도" + (10 - i) + "우선잔량"));
                        volumeListBox.Items.Add(차선잔량);
                    }
                    else
                    {
                        int 차선잔량 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매도" + (10 - i) + "차선잔량"));
                        volumeListBox.Items.Add(차선잔량);
                    }

                }
                int 매도최우선호가 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매도최우선호가"));
                priceListBox.Items.Add(매도최우선호가 + " / 매도최우선호가");
                int 매도최우선잔량 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매도최우선잔량"));
                volumeListBox.Items.Add(매도최우선잔량);

                int 매수최우선호가 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매수최우선호가"));
                priceListBox.Items.Add(매수최우선호가 + " / 매수최우선호가");
                int 매수최우선잔량 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매수최우선잔량"));
                volumeListBox.Items.Add(매수최우선잔량);

                for (int i = 0; i < 9; i++)
                {
                    if (i == 4)
                    {
                        int 호가 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매수" + (2 + i) + "우선호가"));
                        priceListBox.Items.Add(호가 + " / " + (2 + i) + "차선");

                        int 잔량 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매수" + (2 + i) + "우선잔량"));
                        volumeListBox.Items.Add(잔량);
                    }
                    else
                    {
                        int 호가 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매수" + (2 + i) + "차선호가"));
                        priceListBox.Items.Add(호가 + " / " + (2 + i) + "차선");
                        int 잔량 = int.Parse(_axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "매수" + (2 + i) + "차선잔량"));
                        volumeListBox.Items.Add(잔량);
                    }
                }

                MessageBox.Show("매도최우선호가 = " + 매도최우선호가 + "매수최우선호가 = " + 매수최우선호가);
            }
        }

        public void onReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            Console.WriteLine(currentStockCode + "------------------------------------------");
            if (e.sRealType == "주식호가잔량")
            {
                if (e.sRealKey.Equals(currentStockCode))
                {
                    try
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            int 매도호가 = int.Parse(_axKHOpenAPI1.GetCommRealData(e.sRealType, 50 - i));
                            int 매도잔량 = int.Parse(_axKHOpenAPI1.GetCommRealData(e.sRealType, 70 - i));

                            priceListBox.Items[i] = 매도호가 + " / " + (10 - i) + "차선";
                            volumeListBox.Items[i] = 매도잔량;

                            if (i == 9)
                            {
                                priceListBox.Items[i] = 매도호가 + " / 매도최우선호가";
                            }


                        }
                        for (int i = 0; i < 10; i++)
                        {
                            int 매수호가 = int.Parse(_axKHOpenAPI1.GetCommRealData(e.sRealType, 51 + i));
                            int 매수잔량 = int.Parse(_axKHOpenAPI1.GetCommRealData(e.sRealType, 71 + i));

                            priceListBox.Items[10 + i] = 매수호가 + " / " + (i + 1) + "차선";
                            volumeListBox.Items[10 + i] = 매수잔량;

                            if (i == 0)
                            {
                                priceListBox.Items[10 + i] = 매수호가 + " / 매수최우선호가";
                            }

                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message.ToString());

                    }

                }
            }
            else if (e.sRealType == "주식체결")
            {
                if (e.sRealKey.Equals(currentStockCode))
                {
                    long stockPrice = long.Parse(_axKHOpenAPI1.GetCommRealData(e.sRealType, 10).Replace("-", ""));
                    priceLabel.Text = String.Format("{0:#,###}", stockPrice);

                    upDownRateLabel.Text = double.Parse(_axKHOpenAPI1.GetCommRealData(e.sRealType, 12)) + "%";

                }
            }
        }



        public void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (sender.Equals(priceListBox))
            {
                try
                {
                    if (e.Index < 10)
                    {
                        e.Graphics.FillRectangle(Brushes.LightSteelBlue, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.LightPink, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                    String value = priceListBox.Items[e.Index].ToString();
                    Brush brush;

                    if (value[0] == '-')
                    {
                        brush = Brushes.Blue;
                    }
                    else
                    {
                        brush = Brushes.Red;
                    }
                    int x = e.Bounds.X + e.Font.Height / 2;
                    int y = e.Bounds.Y + e.Font.Height / 2;

                    e.Graphics.DrawString(value.Replace("-", ""), e.Font, brush, x, y, StringFormat.GenericDefault);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }
            }
            else if (sender.Equals(volumeListBox))
            {
                try
                {
                    string value = volumeListBox.Items[e.Index].ToString();

                    int x = e.Bounds.X + e.Font.Height / 2 + e.Bounds.Width / 2;
                    int y = e.Bounds.Y + e.Font.Height / 2;

                    e.Graphics.DrawString(value, e.Font, Brushes.Black, x, y, StringFormat.GenericDefault);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());

                }
            }
        }



    }
}
