using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keylogger.DTO
{
    public class Account
    {

        public Account(string TK, string MK) {
            this.TK = TK;
            this.MK = MK;
        }
        public string TK { get; set; }
        public string MK { get; set; }
    }
}
