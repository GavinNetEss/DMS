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
    public partial class MDIParentMain : Form
    {
        private int childFormNumber = 0;

        public MDIParentMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrugDict frm = new FrmDrugDict();
            frm.MdiParent = this;
            frm.Show();
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrugInit frm = new FrmDrugInit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void storageBasicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrugBasic frm = new FrmDrugBasic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void drugBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrugBox frm = new FrmDrugBox();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pwdStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPwdChange childForm = new FrmPwdChange();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void usedRecordBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsedRecord childForm = new FrmUsedRecord();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void wasteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIParentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

     
    }
}
