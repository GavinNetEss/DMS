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
    public partial class FrmBoxList : Form
    {
        #region 属性
        /// <summary>
        /// 操作类型
        /// </summary>
        public string ControlType
        {
            set { _controlType =value ; }
            get { return  _controlType; }
        }
        private string _controlType = "GetOut";
        #endregion 

        public FrmBoxList()
        {
            InitializeComponent();
        }

        private void FrmGetOutBox_Load(object sender, EventArgs e)
        {
            if (this.ControlType == "GetOut")
            {
                //从数据库读取 药箱类别加载药箱类别;
                this.btnBox1.Click += new System.EventHandler(this.BtnGetOut_Click);
                this.btnBox2.Click += new System.EventHandler(this.BtnGetOut_Click);
                this.btnBox3.Click += new System.EventHandler(this.BtnGetOut_Click);
                pnlFootInformation.Visible = false;
            }
            else
            {
                this.btnBox1.Click += new System.EventHandler(this.BtnSet_Click);
                this.btnBox2.Click += new System.EventHandler(this.BtnSet_Click);
                this.btnBox3.Click += new System.EventHandler(this.BtnSet_Click);
                lblInformation.Text = "请设置常用手术箱";
            }
        }

        /// <summary>
        /// 取箱操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2号柜门开启，请取箱、锁门。");
            this.Close();
        }

        /// <summary>
        /// 快速设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSet_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DodgerBlue;
            lblSetBox.Text = btn.Text;
        }

     
    }
}
