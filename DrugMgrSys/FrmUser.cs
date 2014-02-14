using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;

namespace DrugMgrSys
{
    public partial class FrmUser : Form
    {

        private DataTable dtUser;
        BaseOperate.SpellAndWbCode mySpell = new BaseOperate.SpellAndWbCode();
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            dtUser = new DataTable();
            GetUserData();
            BindUser();
            dgvUsers.ClearSelection();
        }

        /// <summary>
        /// 绑定职工列表
        /// </summary>
        private void BindUser()
        {
            dgvUsers.DataSource = dtUser.DefaultView;
        }

        /// <summary>
        /// 查询用户数据
        /// </summary>
        private void GetUserData()
        {
            string sql = "select a.name,a.staff_no,a.title,b.user_name from comm.staff_dict a inner join comm.account b on a.staff_no= b.emp_no";
            DataSet ds = DbHelperOra.Query(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                dtUser = ds.Tables[0];
            }
        }

        /// <summary>
        /// 新增按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            DataRow drNew = dtUser.NewRow();
            dtUser.Rows.Add(drNew); 
            dgvUsers.DataSource = dtUser.DefaultView;

            dgvUsers.ClearSelection();
            dgvUsers.Rows[dgvUsers.Rows.Count - 1].Selected = true;
        }


        /// <summary>
        /// dgvUser 选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1)
            {
                txtName.Text = dgvUsers.SelectedRows[0].Cells["colName"].Value.ToString();
                txtUserName.Text = dgvUsers.SelectedRows[0].Cells["colUserName"].Value.ToString();
                if (dgvUsers.SelectedRows[0].Cells["colTitle"].Value.ToString() == "麻醉医师")
                {
                    rbtnAnesthetist.Checked = true;
                }
                else
                {
                    rbtnNurse.Checked = true;
                }
            }
            else
            {
                txtName.Text = "";
                txtUserName.Text = "";
                rbtnAnesthetist.Checked = false;
                rbtnNurse.Checked = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //当用户名为空时，默认根据姓名生成用户名
            if (txtUserName.Text == "")
            {
                this.txtUserName.Text = mySpell.GetSpellCode(txtName.Text);
            }
        }

    }
}
