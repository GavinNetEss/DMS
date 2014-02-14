using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrugMgrCabinet
{
    public partial class FrmBoxCabinet : Form
    {
        public FrmBoxCabinet()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            FrmBoxLackDrug frm = new FrmBoxLackDrug();
            frm.Show();
            this.Close();
        }
    }
}
