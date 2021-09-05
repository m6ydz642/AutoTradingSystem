using AxKHOpenAPILib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTradingSystem
{
    public partial class FormMain : Form
    {
        public event EventHandler UserInfo;
        public FormMain()
        {
            InitializeComponent();
        }


        #region 사용자 정의 함수

        /// <summary>
        /// new 연산자를 대신하여 객체를 생성
        /// </summary>
        /// <param name="classname"></param>
        public void CreateInstance(string classname)
        {
            Type type = Type.GetType(classname);

            try
            {
                if (type == null)
                {
                    MessageBox.Show(type + "의 인스턴스가 발견되지 않았습니다 \r\nMainForm에서 객체설정이" +
                        "되어있지 않습니다 객체설정 문제입니다", "객체 오류");
                    return;
                }
                else
                {
                    var args = new object[] { axKHOpenAPI1 };
                    /* return Activator.CreateInstance(type, axKHOpenAPI1); // 인스턴스 생성 이렇게 해도 되고*/
                    object createInstance = Activator.CreateInstance(type, args); // 인스턴스 생성 이렇게 해도 됨
                    panel1.Controls.Clear();
                    panel1.Controls.Add((Control)createInstance);

                }
            }
              catch(MissingMethodException e) // 생성자에 파라메터 다르게 되어있어 안맞는 경우
            {
                object args = new object[] { this,axKHOpenAPI1 };
                object createInstance = Activator.CreateInstance(type,  args); // 인스턴스 생성 이렇게 해도 됨
                panel1.Controls.Clear();
                panel1.Controls.Add((Control)createInstance);
            }
            
        }

        /// <summary>
        /// 로그인 되어있으면 객체 생성
        /// </summary>
        /// <param name="classname"></param>
        private void CheckLogin_GetInstance(string classname)
        {
            if (UserInfoModel.userid != null)
            {
                CreateInstance(classname);
            }
            else
            {
                MessageBox.Show("로그인 부터 하세요", "로그인 필요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetLogin();
            }
          
        }

        private void GetLogin()
        {
            int loginstatus = axKHOpenAPI1.CommConnect(); // 로그인 윈도우 띄우기
            // 로그인 윈도우 띄우기 성공했을때 리턴 값으로 0을 반환
            // 실패했을땐 음수 -1 반환
            axKHOpenAPI1.OnEventConnect += onEventConnect; // 이벤트 함수 호출
        }

        #endregion


        #region C# 자체적인 이벤트 함수
        private void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0) // 0은 로그인 성공, 로그인에 성공하면 버튼 숨김
                loginbutton.Hide();

            if (e.nErrCode == 0) /// 이벤트 매개변수를 통해서 핸들러 함수를 받아옴
            {
                string acountlist = axKHOpenAPI1.GetLoginInfo("ACCLIST"); // 계좌 정보 가져오기
                string[] account = acountlist.Split(';');  // 계좌번호 문자열을 나눠 배열로 담음

                for (int i = 0; i < account.Length; i++)
                {
                    accountComboBox.Items.Add(account[i]);
                }

                string userId = axKHOpenAPI1.GetLoginInfo("USER_ID");
                string userName = axKHOpenAPI1.GetLoginInfo("USER_NAME");
                string connectedServer = axKHOpenAPI1.GetLoginInfo("GetServerGubun");
                idLabel.Text = userId;
                nameLabel.Text = userName;
                serverLabel.Text = connectedServer;

                UserInfoModel.userid = userId;
                UserInfoModel.username = userName;
                UserInfoModel.accountlist = account;

            }
            else
            {
                MessageBox.Show("오류 발생");
            }
        }


        private void loginbutton_Click(object sender, EventArgs e)
        {
            GetLogin();
        }

        private void 사용자계좌조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CheckLogin_GetInstance("AutoTradingSystem.Account");

        }

        private void 종목검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CheckLogin_GetInstance("AutoTradingSystem.AskingPrice");

        }

        private void 호가창조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckLogin_GetInstance("AutoTradingSystem.AskingPrice");
        }

        private void 주식매수_주식매도ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckLogin_GetInstance("AutoTradingSystem.Buying_SellStock");
        }


        #endregion

      
    }
}
