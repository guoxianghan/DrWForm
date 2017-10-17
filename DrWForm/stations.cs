using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace DrWForm
{
    public partial class stations : FormBase
    {
        public stations()
        {
            InitializeComponent();
            LoadData();
           
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
        private void LoadData()
        {
            this.WindowState = FormWindowState.Maximized;
            timerDate.Start();
            rbtUserName.Text = "您好：" + base.PersonName;
            menu.PersonID = base.PersonID;
           // menu.Execute();
            deskTop1.ExSort();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rbtUserName_Click(object sender, EventArgs e)
        {

        }

        private void deskTopItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
