namespace AutoAuthenKMITL
{
    partial class UserPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.accountTxt = new System.Windows.Forms.Label();
            this.IpTxt = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Label();
            this.Ip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "HIDDEN";
            this.notifyIcon1.BalloonTipTitle = "AutoAuthenKMITL";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutoAuthenKMITL";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // accountTxt
            // 
            this.accountTxt.AutoSize = true;
            this.accountTxt.Location = new System.Drawing.Point(44, 82);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(53, 13);
            this.accountTxt.TabIndex = 0;
            this.accountTxt.Text = "Account :";
            // 
            // IpTxt
            // 
            this.IpTxt.AutoSize = true;
            this.IpTxt.Location = new System.Drawing.Point(75, 117);
            this.IpTxt.Name = "IpTxt";
            this.IpTxt.Size = new System.Drawing.Size(22, 13);
            this.IpTxt.TabIndex = 0;
            this.IpTxt.Text = "Ip :";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(128, 198);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Location = new System.Drawing.Point(104, 82);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(0, 13);
            this.account.TabIndex = 2;
            // 
            // Ip
            // 
            this.Ip.AutoSize = true;
            this.Ip.Location = new System.Drawing.Point(104, 117);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(0, 13);
            this.Ip.TabIndex = 2;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 299);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.account);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.IpTxt);
            this.Controls.Add(this.accountTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.Resize += new System.EventHandler(this.UserPanel_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label accountTxt;
        private System.Windows.Forms.Label IpTxt;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label Ip;
    }
}