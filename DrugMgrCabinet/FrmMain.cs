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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserInfo.UserName;
            lblUserTitile.Text = UserInfo.UserTitle;
            if (UserInfo.UserType == "anesthetist")
            {
                picbHead.Image = global::DrugMgrCabinet.Properties.Resources.DocHead;
                pnlMenuAnesthetist.Visible = true;
            }
            else
            {
                picbHead.Image = global::DrugMgrCabinet.Properties.Resources.NurseHead;
                pnlMenuNurse.Visible = true;
            }
        }     

        private void btnFasterGetOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2号柜门开启，请取箱、锁门。");
        }

        private void btnPutIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2号柜门开启，请存箱、锁门。");
        }

        #region 窗体关闭操作
        private void btnLogout_Click(object sender, EventArgs e)
        {
            CloseAllChildrenForm();
            this.Close();
        }
        private void pnlClose_Click(object sender, EventArgs e)
        {
            CloseAllChildrenForm();
            this.Close();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            CloseAllChildrenForm();
        }

        /// <summary>
        /// 关闭所有弹出的子窗体
        /// </summary>
        private void CloseAllChildrenForm()
        {
            int count = frmChildrenList.Count;
            if (count > 0)
            {
                foreach (Form frm in frmChildrenList)
                {
                    frm.Close();
                }
            }
        }

        #endregion

        #region 主页按钮操作
        private List<Form> frmChildrenList=new List<Form>();

        private void btnGetOut_Click(object sender, EventArgs e)
        {
            FrmBoxList frm = new FrmBoxList();            
            frm.ControlType = "GetOut";

            frmChildrenList.Add(frm);
            frm.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            FrmBoxList frm = new FrmBoxList();
            frm.ControlType = "Set";
            frmChildrenList.Add(frm);
            frm.Show();
        }

        private void btnCheckBoxCabinet_Click(object sender, EventArgs e)
        {
            FrmBoxCabinet frm = new FrmBoxCabinet();
            frmChildrenList.Add(frm);
            frm.Show();
        }
        
        #endregion  

        private void btnNurseStoreDrug_Click(object sender, EventArgs e)
        {
            FrmDrugCabinetAllocation frm = new FrmDrugCabinetAllocation();
            frm.ControlType = "上药";
            
            frm.Show();
        }

        private void btnGetOutDrug_Click(object sender, EventArgs e)
        {
            FrmDrugCabinetAllocation frm = new FrmDrugCabinetAllocation();
            frm.ControlType = "取药";
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmDrugCabinetAllocation frm = new FrmDrugCabinetAllocation();
            frm.ControlType = "盘点";
            frm.Show();
        }

      
    }
}
