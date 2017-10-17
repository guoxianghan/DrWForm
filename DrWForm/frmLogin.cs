using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Dr.WForm.Base.Core.Data;
using Dr.WForm.Base.Foundation;

namespace DrWForm
{
    public partial class frmLogin : FormBase
    {
        public frmLogin()
        {
            InitializeComponent();
            //DataServiceInterface service =news DataServiceInterface();
            //if (!service.CheckOnLine())
            //{
            //    MessageBox.Show("联网失败,请检查网络");
            //    Application.Exit(); 
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfo.PersonName = txtPersonCode.Text;
            frmMain aa = new frmMain();
            aa.Show();
            this.Hide();
            return;
            DataServiceInterface service = new DataServiceInterface();
            bool Result = service.userLogin(txtPersonCode.Text, txtPassWord.Text);
            if (Result)
            {
                LoginManager login = new LoginManager();
                login.AuthenticateUser(txtPersonCode.Text);
                frmMain a = new frmMain();
                a.Show();
                this.Hide();
            }
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }
    }
}
