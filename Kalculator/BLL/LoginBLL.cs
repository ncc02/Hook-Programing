using Keylogger.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keylogger.BLL
{
    public class LoginBLL
    {
        public bool CheckLogin(Account account)
        {
            if ((account.TK == "admin" && account.MK=="admin@123")
                || (account.TK == "user" && account.MK == "user@123"))
                return true;
            return false;
        }
    }
}
