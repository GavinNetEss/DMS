using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrugMgrSys
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string pwd = txtPwd.Text;
            if (userName == "admin" && pwd == "admin")
            {
                MDIParentMain frm = new MDIParentMain();
                frm.Show();
                this.Hide();

                //FrmMain frm = new FrmMain();
                //frm.Show();
            }
            else
            {
            }
        }
    }
}
