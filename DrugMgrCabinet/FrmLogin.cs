using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DrugMgrCabinet
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtCardLogin.Focus();
        }

        private void lblLog_Click(object sender, EventArgs e)
        {
            pnlLogin.Location = lblLog.Location;
            pnlLogin.Visible = true;
            //gbKeyBoard.Visible = true;
            lblLog.Visible = false;
            txtUserName.Focus();

            FrmKeyBoard frm = new FrmKeyBoard();
            frm.Show();
        }

        private void pnlLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCardLogin.Focus();
            pnlLogin.Visible = false;
            //gbKeyBoard.Visible = false;
            lblLog.Visible = true;
        }

        private void gbKeyBoard_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string pwd = txtPwd.Text;
            if (userName == "admin" && pwd == "admin")
            {
                UserInfo.UserName = userName;
                UserInfo.UserTitle = "麻醉医师";
                UserInfo.UserType = "anesthetist";

                FrmMain frm = new FrmMain();
                frm.Show();
            }
            else
            {
                UserInfo.UserName = "李护士";
                UserInfo.UserTitle = "专职药师";
                UserInfo.UserType = "Nurse";

                FrmMain frm = new FrmMain();
                frm.Show();
            }
        }
        
        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetKeyValue((Button)sender);
        }

        
        private void GetKeyValue(Button btn)
        {
            
        }

      
       

    }
}
