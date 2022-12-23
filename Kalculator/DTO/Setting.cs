using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Keylogger.DTO
{
    public class Setting
    {

        public Setting(string LOG_FILE_NAME, int MAX_LOG_LENGTH_BEFORE_SENDING_EMAIL) {
            this.LOG_FILE_NAME = LOG_FILE_NAME;
            this.MAX_LOG_LENGTH_BEFORE_SENDING_EMAIL = MAX_LOG_LENGTH_BEFORE_SENDING_EMAIL;
        }
        
        public string LOG_FILE_NAME{get; set;}
        public int MAX_LOG_LENGTH_BEFORE_SENDING_EMAIL{get; set;}
    
    }
}
