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
    public partial class FrmBoxLackDrug : Form
    {
        public FrmBoxLackDrug()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmDrugCabinetAllocation frm = new FrmDrugCabinetAllocation();
            frm.Show();
            this.Close();
        }
    }
}
