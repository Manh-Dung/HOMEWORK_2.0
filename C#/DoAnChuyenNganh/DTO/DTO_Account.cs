using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        private string userName, passWord, newPassword;
        private int permission;
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string NewPassword { get => newPassword; set => newPassword = value; }
        public int Permission { get => permission; set => permission = value; }
    }
}
