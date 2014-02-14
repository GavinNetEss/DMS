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
    public partial class FrmDrugCabinetAllocation : Form
    {

        #region 属性
        /// <summary>
        /// 操作类型
        /// </summary>
        public string ControlType
        {
            set { _controlType = value; }
            get { return _controlType; }
        }
        private string _controlType = "GetOut";
        #endregion 

        public FrmDrugCabinetAllocation()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDrugCabinetAllocation_Load(object sender, EventArgs e)
        {
            switch  (ControlType)
            {
                case "上药":
                    lblInformation.Text = "请记录上药数量";    
                    this.button15.Click += new System.EventHandler(this.ShowNumBoard);
                    this.button15.Font = new System.Drawing.Font("微软雅黑", 12F);
                    break;
                case "取药":
                    lblInformation.Text = "请记录取药数量";
                    this.button15.Click += new System.EventHandler(this.ShowNumBoard);
                    this.button15.Font = new System.Drawing.Font("微软雅黑", 12F);
                    break;
                case "盘点":
                    lblInformation.Text = "请记录盘点数量";
                    this.button15.Click += new System.EventHandler(this.ShowNumBoard);
                    this.button15.Font = new System.Drawing.Font("微软雅黑", 12F);
                    break;
                default:
                    this.button2.BackColor = System.Drawing.Color.DodgerBlue;
                    this.button4.BackColor = System.Drawing.Color.LawnGreen;
                    this.button9.Font = new System.Drawing.Font("微软雅黑", 12F);
                    this.button9.BackColor = System.Drawing.Color.DodgerBlue;
                    this.button9.Text = "阿托品 3支";
                    break;
            }
        }


        private void ShowNumBoard(object sender, EventArgs e)
        {
            this.button15.BackColor = System.Drawing.Color.DodgerBlue;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Text = "阿托品";

            gbNumBoard.Visible = true;
            //FrmNumberBoard frm = new FrmNumberBoard();
            //frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            switch (ControlType)
            {
                case "盘点":
                    this.button15.BackColor = System.Drawing.Color.LawnGreen;
                    break;
                default:
                    break;
            }

            gbNumBoard.Visible = false;
        }


    }
}
