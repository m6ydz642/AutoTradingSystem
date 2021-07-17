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
          // 참조하는게 없어 호출을 못함
        }

        public Account(FormMain main, AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1)
        {
            InitializeComponent();
            // 원래 기본생성자에 있어야 하는데 idLabel.text등 Main에서 객체 생성시  디자이너 호출(?) 을 못해 null 을 반환하기때문에 
            // 인자있는 생성자에서 생성할때 InitializeComponent()를 호출함
            _axKHOpenAPI1 = axKHOpenAPI1;
            this.main = main;


            idLabel.Text = Model.userid;
            nameLabel.Text = Model.username;
            serverLabel.Text = "정보 일부러 안넣음";
            passwordTextBox.TextAlignChanged += encryptPassword;

            for (int i = 0; i < Model.accountlist.Length; i++)
            {
                accountComboBox.Items.Add(Model.accountlist[i]);

            }

        }

        private void encryptPassword(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*'; // 암호표시
            passwordTextBox.MaxLength = 4; // 최대 4자리
        }

        private void blanceCheckButton_Click(object sender, EventArgs e)
        {
         //   _axKHOpenAPI1.SetInputValue("비밀번호", passwordTextBox.Text);
        }
    }
}
