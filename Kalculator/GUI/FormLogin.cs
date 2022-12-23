using Keylogger.BLL;
using Keylogger.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keylogger.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

     
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginBLL bll = new LoginBLL();
            if (bll.CheckLogin(new Account(txtTK.Text, txtMK.Text)))
            {
                this.Visible = false;

                    FormKeylogger f = new FormKeylogger();
                    f.Show();
            }
            else
            {
                lblError.Text = "Tài khoản hoặc mật khẩu không đúng!";
            }
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
