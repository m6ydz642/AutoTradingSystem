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
        public FormMain()

        {
            InitializeComponent();
            axKHOpenAPI1.CommConnect(); // 로그인 윈도우 띄우기
            // 로그인 윈도우 띄우기 성공했을때 리턴 값으로 0을 반환
            // 실패했을땐 음수 반환
            axKHOpenAPI1.OnEventConnect += onEventConnect; // 이벤트 함수 호출
        }

        private void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0) /// 이벤트 매개변수를 통해서 핸들러 함수를 받아옴
            {

            }
            else
            {
                MessageBox.Show("오류 발생");
            }
        }
    }
}
