using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AutoAuthenKMITL.Utils;
using AutoAuthenKMITL.Controller;


namespace AutoAuthenKMITL
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        private void chLogin() {
            while (true) { 
            while (Network.checkShouldLoginStatus()) {
                UserController.sendLogin(DataStrac.username, DataStrac.password);
                }
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Controller.UserController.sendLogout();
            new Main().Show();
            Hide();

        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Panel_Load(object sender, EventArgs e)
        {
              account.Text = DataStrac.account;
              Ip.Text = DataStrac.ip;
              Thread th = new Thread(chLogin);
              th.Start();
        }
    }
}
