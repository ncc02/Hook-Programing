namespace Keylogger.GUI
{
    partial class FormKeylogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblRun = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutlook = new System.Windows.Forms.TextBox();
            this.cbHiden = new System.Windows.Forms.CheckBox();
            this.cbOutlook = new System.Windows.Forms.CheckBox();
            this.cbStartUp = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(299, 36);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(305, 27);
            this.txtLog.TabIndex = 1;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(63, 97);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(205, 20);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Số kí tự tối đa trong 1 file log";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(299, 93);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(114, 27);
            this.txtNum.TabIndex = 4;
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.ForeColor = System.Drawing.Color.Yellow;
            this.lblRun.Location = new System.Drawing.Point(260, 440);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(153, 20);
            this.lblRun.TabIndex = 5;
            this.lblRun.Text = "Keylogger đang chạy!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutlook);
            this.groupBox1.Controls.Add(this.cbHiden);
            this.groupBox1.Controls.Add(this.cbOutlook);
            this.groupBox1.Controls.Add(this.cbStartUp);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(70, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng";
            // 
            // txtOutlook
            // 
            this.txtOutlook.Location = new System.Drawing.Point(288, 131);
            this.txtOutlook.Name = "txtOutlook";
            this.txtOutlook.Size = new System.Drawing.Size(219, 27);
            this.txtOutlook.TabIndex = 1;
            this.txtOutlook.Text = "cuongtk2002@gmail.com";
            // 
            // cbHiden
            // 
            this.cbHiden.AutoSize = true;
            this.cbHiden.Location = new System.Drawing.Point(22, 36);
            this.cbHiden.Name = "cbHiden";
            this.cbHiden.Size = new System.Drawing.Size(137, 24);
            this.cbHiden.TabIndex = 0;
            this.cbHiden.Text = "Ẩn chương trình";
            this.cbHiden.UseVisualStyleBackColor = true;
            // 
            // cbOutlook
            // 
            this.cbOutlook.AutoSize = true;
            this.cbOutlook.Checked = true;
            this.cbOutlook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOutlook.Location = new System.Drawing.Point(22, 132);
            this.cbOutlook.Name = "cbOutlook";
            this.cbOutlook.Size = new System.Drawing.Size(260, 24);
            this.cbOutlook.TabIndex = 0;
            this.cbOutlook.Text = "Tự động gửi mail khi đạt max kí tự";
            this.cbOutlook.UseVisualStyleBackColor = true;
            // 
            // cbStartUp
            // 
            this.cbStartUp.AutoSize = true;
            this.cbStartUp.Location = new System.Drawing.Point(22, 84);
            this.cbStartUp.Name = "cbStartUp";
            this.cbStartUp.Size = new System.Drawing.Size(192, 24);
            this.cbStartUp.TabIndex = 0;
            this.cbStartUp.Text = "Khởi động cùng window";
            this.cbStartUp.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(441, 377);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(129, 377);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nơi lưu file log";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // FormKeylogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(74)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(655, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKeylogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keylogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtLog;
        private Label lblNum;
        private TextBox txtNum;
        private Label lblRun;
        private GroupBox groupBox1;
        private TextBox txtOutlook;
        private CheckBox cbHiden;
        private CheckBox cbOutlook;
        private CheckBox cbStartUp;
        private Button btnExit;
        private Button btnSave;
        private Button button1;
    }
}