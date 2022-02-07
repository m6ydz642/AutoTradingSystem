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
    public partial class Account : UserControl
    {
        private AxKHOpenAPILib.AxKHOpenAPI _axKHOpenAPI1;
        private FormMain main;
        public Account()
        {
            InitializeComponent();
            // 원래 기본생성자에 있어야 하는데 idLabel.text등 Main에서 객체 생성시  디자이너 호출(?) 을 못해 null 을 반환하기때문에 
            // 인자있는 생성자에서 생성할때 InitializeComponent()를 호출함

            idLabel.Text = UserInfoModel.userid;
            nameLabel.Text = UserInfoModel.username;
            serverLabel.Text = "정보 일부러 안넣음";

         //   passwordTextBox.TextChanged += encryptPassword; // 패스워드 표시 * 이벤트 함수
         // 키움증권 api에서 관리 하는데 왜 했는지 의문
          
            for (int i = 0; i < UserInfoModel.accountlist.Length; i++)
            {
                accountComboBox.Items.Add(UserInfoModel.accountlist[i]); // 오른쪽에 메인과 같은 콤보박스 
                accountComboBox2.Items.Add(UserInfoModel.accountlist[i]); // 계좌잔고요청 쪽에 콤보박스


            }

            passwordTextBox.Click += PasswordTextBox_Click;

        }

        public Account(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1, FormMain main) : this() // 동시에 기본생성자 호출
        {
    
            _axKHOpenAPI1 = axKHOpenAPI1;
            this.main = main;
            _axKHOpenAPI1.OnReceiveTrData += onReceiveTrData; // 비밀번호 입력후 계좌 잔고요청에 성공하면 정보를 받았기 때문에 호출됨
        }

        private void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            string sScrNo = e.sScrNo;
            string sRQName = e.sRQName;
            string sTrCode = e.sTrCode;
            string sRecordName = e.sRecordName;
            string sPrevNext = e.sPrevNext;
            string sErrorCode = e.sErrorCode;
            object test = _axKHOpenAPI1.GetCommData(sTrCode, sRQName, 0, "총매입금액");
            

            try
            {
                long totalPurchase = long.Parse(_axKHOpenAPI1.GetCommData(sTrCode, sRQName, 0, "총매입금액"));
                long totalEstimate = long.Parse(_axKHOpenAPI1.GetCommData(sTrCode, sRQName, 0, "총평가금액"));
                long totalProfitLoss = long.Parse(_axKHOpenAPI1.GetCommData(sTrCode, sRQName, 0, "총평가손익금액"));
                double totalProfitRate = long.Parse(_axKHOpenAPI1.GetCommData(sTrCode, sRQName, 0, "총수익률(%)"));

                totalProfitRateLabel.Text = String.Format("{0:#,###}", totalPurchase);
                totalEstimateLabel.Text = String.Format("{0:#,###}", totalEstimate);
                totalProfitLabel.Text = String.Format("{0:#,###}", totalProfitLoss);
                totalProfitRateLabel.Text = String.Format("{0:f2}", totalProfitRate); // 소수점 둘째까지

            }
            catch (FormatException ex)
            {
                MessageBox.Show("기타 예외가 발생하였습니다 \r\n(로그인 정보가 없어도 본 오류가 뜹니다) \r\n" + ex); 
                // 로그인 정보 없으면 형변환 오류떠서 if문으로 안하고 그냥 try catch로 함
            }
           
        }


        private void encryptPassword(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*'; // 암호표시
            passwordTextBox.MaxLength = 4; // 최대 4자리
        }

        private void blanceCheckButton_Click(object sender, EventArgs e) // 계좌잔고요청 버튼 
        {
            string accountNumber = accountComboBox2.Text;
            string password = passwordTextBox.Text;

            // _axKHOpenAPI1.SetInputValue("비밀번호", password); // 왜만들었는지 알 수가 없는
             if (accountNumber == "") // 계좌 선택이 되어 있으면 openApi 비밀번호 팝업 띄움
                                      //    _axKHOpenAPI1.KOA_Functions("ShowAccountWindow", "");

                passwordTextBox.Click += PasswordTextBox_Click;

            _axKHOpenAPI1.SetInputValue("계좌번호", accountNumber);
            _axKHOpenAPI1.CommRqData("계좌평가잔고내역요청", "opw00018", 0, "8100");

        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            _axKHOpenAPI1.KOA_Functions("ShowAccountWindow", "");
        }
    }
}
