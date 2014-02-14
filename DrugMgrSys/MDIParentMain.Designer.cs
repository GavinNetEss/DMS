namespace DrugMgrSys
{
    partial class MDIParentMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageBasicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.drugBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usedRecordBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.智能柜上药查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.智能柜取药查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.智能柜盘点记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.药箱补药记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.药箱领用记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.药箱归还记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.消耗记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回收物统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysSetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pwdStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.sysSetMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(662, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(83, 21);
            this.fileMenu.Text = "人员管理(&P)";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem.Text = "用户管理(&U)";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.storageBasicToolStripMenuItem,
            this.toolStripSeparator3,
            this.drugBoxToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(85, 21);
            this.editMenu.Text = "药品管理(&D)";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.undoToolStripMenuItem.Text = "药品目录(&D)";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // storageBasicToolStripMenuItem
            // 
            this.storageBasicToolStripMenuItem.Name = "storageBasicToolStripMenuItem";
            this.storageBasicToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.storageBasicToolStripMenuItem.Text = "库存基数";
            this.storageBasicToolStripMenuItem.Click += new System.EventHandler(this.storageBasicToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // drugBoxToolStripMenuItem
            // 
            this.drugBoxToolStripMenuItem.Name = "drugBoxToolStripMenuItem";
            this.drugBoxToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.drugBoxToolStripMenuItem.Text = "药箱设置";
            this.drugBoxToolStripMenuItem.Click += new System.EventHandler(this.drugBoxToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usedRecordBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(88, 21);
            this.viewMenu.Text = "日常登记(&W)";
            // 
            // usedRecordBarToolStripMenuItem
            // 
            this.usedRecordBarToolStripMenuItem.Name = "usedRecordBarToolStripMenuItem";
            this.usedRecordBarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.usedRecordBarToolStripMenuItem.Text = "手术消耗登记(&T)";
            this.usedRecordBarToolStripMenuItem.Click += new System.EventHandler(this.usedRecordBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.智能柜上药查询ToolStripMenuItem,
            this.智能柜取药查询ToolStripMenuItem,
            this.智能柜盘点记录ToolStripMenuItem,
            this.toolStripSeparator2,
            this.药箱补药记录ToolStripMenuItem,
            this.药箱领用记录ToolStripMenuItem,
            this.药箱归还记录ToolStripMenuItem,
            this.toolStripSeparator1,
            this.消耗记录查询ToolStripMenuItem,
            this.回收物统计ToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(84, 21);
            this.toolsMenu.Text = "查询统计(&R)";
            // 
            // 智能柜上药查询ToolStripMenuItem
            // 
            this.智能柜上药查询ToolStripMenuItem.Name = "智能柜上药查询ToolStripMenuItem";
            this.智能柜上药查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.智能柜上药查询ToolStripMenuItem.Text = "智能柜上药记录";
            // 
            // 智能柜取药查询ToolStripMenuItem
            // 
            this.智能柜取药查询ToolStripMenuItem.Name = "智能柜取药查询ToolStripMenuItem";
            this.智能柜取药查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.智能柜取药查询ToolStripMenuItem.Text = "智能柜取药记录";
            // 
            // 智能柜盘点记录ToolStripMenuItem
            // 
            this.智能柜盘点记录ToolStripMenuItem.Name = "智能柜盘点记录ToolStripMenuItem";
            this.智能柜盘点记录ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.智能柜盘点记录ToolStripMenuItem.Text = "智能柜盘点记录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // 药箱补药记录ToolStripMenuItem
            // 
            this.药箱补药记录ToolStripMenuItem.Name = "药箱补药记录ToolStripMenuItem";
            this.药箱补药记录ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.药箱补药记录ToolStripMenuItem.Text = "药箱补药记录";
            // 
            // 药箱领用记录ToolStripMenuItem
            // 
            this.药箱领用记录ToolStripMenuItem.Name = "药箱领用记录ToolStripMenuItem";
            this.药箱领用记录ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.药箱领用记录ToolStripMenuItem.Text = "药箱领用记录";
            // 
            // 药箱归还记录ToolStripMenuItem
            // 
            this.药箱归还记录ToolStripMenuItem.Name = "药箱归还记录ToolStripMenuItem";
            this.药箱归还记录ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.药箱归还记录ToolStripMenuItem.Text = "药箱归还记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // 消耗记录查询ToolStripMenuItem
            // 
            this.消耗记录查询ToolStripMenuItem.Name = "消耗记录查询ToolStripMenuItem";
            this.消耗记录查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.消耗记录查询ToolStripMenuItem.Text = "药品消耗统计";
            // 
            // 回收物统计ToolStripMenuItem
            // 
            this.回收物统计ToolStripMenuItem.Name = "回收物统计ToolStripMenuItem";
            this.回收物统计ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.回收物统计ToolStripMenuItem.Text = "回收物品统计";
            // 
            // sysSetMenu
            // 
            this.sysSetMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pwdStripMenuItem});
            this.sysSetMenu.Name = "sysSetMenu";
            this.sysSetMenu.Size = new System.Drawing.Size(83, 21);
            this.sysSetMenu.Text = "个人设置(&S)";
            // 
            // pwdStripMenuItem
            // 
            this.pwdStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pwdStripMenuItem.Name = "pwdStripMenuItem";
            this.pwdStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pwdStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pwdStripMenuItem.Text = "密码修改(&P)";
            this.pwdStripMenuItem.Click += new System.EventHandler(this.pwdStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(64, 21);
            this.windowsMenu.Text = "窗口(&W)";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cascadeToolStripMenuItem.Text = "层叠(&C)";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tileVerticalToolStripMenuItem.Text = "垂直平铺(&V)";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tileHorizontalToolStripMenuItem.Text = "水平平铺(&H)";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.closeAllToolStripMenuItem.Text = "全部关闭(&L)";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 396);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(662, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // MDIParentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 418);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParentMain";
            this.Text = "麻醉药房智能管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParentMain_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem pwdStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem usedRecordBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageBasicToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem drugBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysSetMenu;
        private System.Windows.Forms.ToolStripMenuItem 智能柜上药查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 智能柜取药查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 智能柜盘点记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 消耗记录查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 药箱领用记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回收物统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药箱归还记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药箱补药记录ToolStripMenuItem;
    }
}



