using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTradingSystem
{
    class UserInfoArgs : EventArgs
    {
        string id, account;
        public UserInfoArgs(string id, string account) {
            this.id = id;
            this.account = account;
        }
    }
}
