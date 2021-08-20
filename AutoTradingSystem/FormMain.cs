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
    public partial class FormMain : Form
    {
        public event EventHandler UserInfo;
        public FormMain()
        {
            InitializeComponent();
        }

   
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

                Model.userid = userId;
                Model.username = userName;
                Model.accountlist = account;

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
        private void GetLogin()
        {
            int loginstatus = axKHOpenAPI1.CommConnect(); // 로그인 윈도우 띄우기
            // 로그인 윈도우 띄우기 성공했을때 리턴 값으로 0을 반환
            // 실패했을땐 음수 -1 반환
            axKHOpenAPI1.OnEventConnect += onEventConnect; // 이벤트 함수 호출
        }
        private void 사용자계좌조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Model.userid != null)
            {
                //  UserInfoArgs info = new UserInfoArgs();
                panel1.Controls.Clear();
                Account account = new Account(this, axKHOpenAPI1); // usercontrol 호출할때 생성자로 값 전달
                panel1.Controls.Add(account);
             }
             else
             {
                 MessageBox.Show("로그인 부터 하세요","로그인 필요",MessageBoxButtons.OK, MessageBoxIcon.Error);
                 // loginbutton_Click(sender, e);
                 GetLogin();
             }
        }

        private void 종목검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Model.userid != null)
            {
                //  UserInfoArgs info = new UserInfoArgs();
                panel1.Controls.Clear();
                StockSearchUCV searchucv = new StockSearchUCV(this, axKHOpenAPI1); // usercontrol 호출할때 생성자로 값 전달
                panel1.Controls.Add(searchucv);
            }
            else
            {
                MessageBox.Show("로그인 부터 하세요", "로그인 필요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // loginbutton_Click(sender, e);
                GetLogin();
            }
        }

        private void 호가창조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Model.userid != null)
            {
                panel1.Controls.Clear();
                AskingPrice searchucv = new AskingPrice(axKHOpenAPI1); // usercontrol 호출할때 생성자로 값 전달
                panel1.Controls.Add(searchucv);
            }
            else
            {
                MessageBox.Show("로그인 부터 하세요", "로그인 필요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // loginbutton_Click(sender, e);
                GetLogin();
            }
           
        }

        private void 주식주문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Model.userid != null)
            {
                panel1.Controls.Clear();
                BuyingStock buying = new BuyingStock(axKHOpenAPI1); // usercontrol 호출할때 생성자로 값 전달
                panel1.Controls.Add(buying);
            }
            else
            {
                MessageBox.Show("로그인 부터 하세요", "로그인 필요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // loginbutton_Click(sender, e);
                GetLogin();
            }
        }
    }
}
