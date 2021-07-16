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
        public Account()
        {
            InitializeComponent();

            idLabel.Text = Model.userid;
            nameLabel.Text = Model.username;
            serverLabel.Text = "정보 일부러 안넣음";


            for (int i = 0; i < Model.accountlist.Length; i++)
            {
                accountComboBox.Items.Add(Model.accountlist[i]);

            }
        }

     
    }
}
