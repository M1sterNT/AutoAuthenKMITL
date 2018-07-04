using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoAuthenKMITL.Controller;

namespace AutoAuthenKMITL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //  cradit.Text = checkShouldLoginStatus().ToString();
      
            if (Properties.Settings.Default.Remember) {
                username.Text = Properties.Settings.Default.UserName;
                password.Text = Properties.Settings.Default.PassWord;
                Remember.Checked = Properties.Settings.Default.Remember;
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (Remember.Checked)
            {
                saveSetting();
            }
            if (!UserController.sendLogin(username.Text, password.Text))
            {
                MessageBox.Show("UserName , Password Wrong");
            }
            else
            {
                new UserControl().Show();
                //Hide();
            }
        }
        private bool getRemember()
        {
            return Properties.Settings.Default.Remember;
        }
        private string getUserName()
        {
            return Properties.Settings.Default.UserName;
        }
        private string getPassWord()
        {
            return Properties.Settings.Default.PassWord;
        }
        private void saveSetting() {
            Properties.Settings.Default.Remember = Remember.Checked;
            Properties.Settings.Default.UserName = username.Text;
            Properties.Settings.Default.PassWord = password.Text;
            Properties.Settings.Default.Save();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
