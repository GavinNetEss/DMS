namespace DrugMgrCabinet
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlClose = new System.Windows.Forms.Panel();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserTitile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.picbHead = new System.Windows.Forms.PictureBox();
            this.txtCardLogin = new System.Windows.Forms.TextBox();
            this.btnFasterGetOut = new System.Windows.Forms.Button();
            this.btnPutIn = new System.Windows.Forms.Button();
            this.btnGetOut = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.pnlMenuAnesthetist = new System.Windows.Forms.Panel();
            this.pnlMenuNurse = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetOutDrug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnCheckBoxCabinet = new System.Windows.Forms.Button();
            this.btnBox2 = new System.Windows.Forms.Button();
            this.btnNurseStoreDrug = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbHead)).BeginInit();
            this.pnlMenuAnesthetist.SuspendLayout();
            this.pnlMenuNurse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.Location = new System.Drawing.Point(974, 1);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(50, 50);
            this.pnlClose.TabIndex = 4;
            this.pnlClose.Click += new System.EventHandler(this.pnlClose_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnDefault);
            this.gbLogin.Controls.Add(this.btnLogout);
            this.gbLogin.Controls.Add(this.lblUserTitile);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.lblUserName);
            this.gbLogin.Controls.Add(this.lblLog);
            this.gbLogin.Controls.Add(this.picbHead);
            this.gbLogin.Controls.Add(this.txtCardLogin);
            this.gbLogin.Location = new System.Drawing.Point(75, 70);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(269, 635);
            this.gbLogin.TabIndex = 5;
            this.gbLogin.TabStop = false;
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDefault.Location = new System.Drawing.Point(139, 365);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 36);
            this.btnDefault.TabIndex = 9;
            this.btnDefault.Text = "主页";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLogout.Location = new System.Drawing.Point(54, 365);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 36);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserTitile
            // 
            this.lblUserTitile.AutoSize = true;
            this.lblUserTitile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserTitile.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lblUserTitile.Location = new System.Drawing.Point(128, 298);
            this.lblUserTitile.Name = "lblUserTitile";
            this.lblUserTitile.Size = new System.Drawing.Size(110, 31);
            this.lblUserTitile.TabIndex = 7;
            this.lblUserTitile.Text = "麻醉医师";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label2.Location = new System.Drawing.Point(53, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "职称：";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lblUserName.Location = new System.Drawing.Point(128, 258);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 31);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "XXX";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLog.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lblLog.Location = new System.Drawing.Point(53, 258);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(86, 31);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "用户：";
            // 
            // picbHead
            // 
            this.picbHead.Image = global::DrugMgrCabinet.Properties.Resources.DocHead;
            this.picbHead.Location = new System.Drawing.Point(54, 61);
            this.picbHead.Name = "picbHead";
            this.picbHead.Size = new System.Drawing.Size(160, 155);
            this.picbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbHead.TabIndex = 0;
            this.picbHead.TabStop = false;
            // 
            // txtCardLogin
            // 
            this.txtCardLogin.Location = new System.Drawing.Point(94, 111);
            this.txtCardLogin.Name = "txtCardLogin";
            this.txtCardLogin.Size = new System.Drawing.Size(100, 21);
            this.txtCardLogin.TabIndex = 4;
            // 
            // btnFasterGetOut
            // 
            this.btnFasterGetOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFasterGetOut.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnFasterGetOut.Location = new System.Drawing.Point(45, 21);
            this.btnFasterGetOut.Name = "btnFasterGetOut";
            this.btnFasterGetOut.Size = new System.Drawing.Size(127, 68);
            this.btnFasterGetOut.TabIndex = 9;
            this.btnFasterGetOut.Text = "快速取箱";
            this.btnFasterGetOut.UseVisualStyleBackColor = true;
            this.btnFasterGetOut.Click += new System.EventHandler(this.btnFasterGetOut_Click);
            // 
            // btnPutIn
            // 
            this.btnPutIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPutIn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPutIn.Location = new System.Drawing.Point(45, 133);
            this.btnPutIn.Name = "btnPutIn";
            this.btnPutIn.Size = new System.Drawing.Size(127, 68);
            this.btnPutIn.TabIndex = 11;
            this.btnPutIn.Text = "存      箱";
            this.btnPutIn.UseVisualStyleBackColor = true;
            this.btnPutIn.Click += new System.EventHandler(this.btnPutIn_Click);
            // 
            // btnGetOut
            // 
            this.btnGetOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetOut.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnGetOut.Location = new System.Drawing.Point(247, 21);
            this.btnGetOut.Name = "btnGetOut";
            this.btnGetOut.Size = new System.Drawing.Size(127, 68);
            this.btnGetOut.TabIndex = 12;
            this.btnGetOut.Text = "取      箱";
            this.btnGetOut.UseVisualStyleBackColor = true;
            this.btnGetOut.Click += new System.EventHandler(this.btnGetOut_Click);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSet.Location = new System.Drawing.Point(247, 133);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(127, 68);
            this.btnSet.TabIndex = 13;
            this.btnSet.Text = "常用设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // pnlMenuAnesthetist
            // 
            this.pnlMenuAnesthetist.Controls.Add(this.btnSet);
            this.pnlMenuAnesthetist.Controls.Add(this.btnFasterGetOut);
            this.pnlMenuAnesthetist.Controls.Add(this.btnGetOut);
            this.pnlMenuAnesthetist.Controls.Add(this.btnPutIn);
            this.pnlMenuAnesthetist.Location = new System.Drawing.Point(445, 110);
            this.pnlMenuAnesthetist.Name = "pnlMenuAnesthetist";
            this.pnlMenuAnesthetist.Size = new System.Drawing.Size(449, 218);
            this.pnlMenuAnesthetist.TabIndex = 14;
            this.pnlMenuAnesthetist.Visible = false;
            // 
            // pnlMenuNurse
            // 
            this.pnlMenuNurse.Controls.Add(this.button2);
            this.pnlMenuNurse.Controls.Add(this.btnGetOutDrug);
            this.pnlMenuNurse.Controls.Add(this.label1);
            this.pnlMenuNurse.Controls.Add(this.panel2);
            this.pnlMenuNurse.Controls.Add(this.lblInformation);
            this.pnlMenuNurse.Controls.Add(this.btnCheckBoxCabinet);
            this.pnlMenuNurse.Controls.Add(this.btnBox2);
            this.pnlMenuNurse.Controls.Add(this.btnNurseStoreDrug);
            this.pnlMenuNurse.Location = new System.Drawing.Point(372, 80);
            this.pnlMenuNurse.Name = "pnlMenuNurse";
            this.pnlMenuNurse.Size = new System.Drawing.Size(628, 625);
            this.pnlMenuNurse.TabIndex = 15;
            this.pnlMenuNurse.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.Location = new System.Drawing.Point(454, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 68);
            this.button2.TabIndex = 22;
            this.button2.Text = "盘点";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGetOutDrug
            // 
            this.btnGetOutDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetOutDrug.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnGetOutDrug.Location = new System.Drawing.Point(277, 439);
            this.btnGetOutDrug.Name = "btnGetOutDrug";
            this.btnGetOutDrug.Size = new System.Drawing.Size(127, 68);
            this.btnGetOutDrug.TabIndex = 21;
            this.btnGetOutDrug.Text = "取药";
            this.btnGetOutDrug.UseVisualStyleBackColor = true;
            this.btnGetOutDrug.Click += new System.EventHandler(this.btnGetOutDrug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label1.Location = new System.Drawing.Point(95, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "智能柜操作";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(101, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 10);
            this.panel2.TabIndex = 19;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInformation.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lblInformation.Location = new System.Drawing.Point(94, 51);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(134, 31);
            this.lblInformation.TabIndex = 18;
            this.lblInformation.Text = "套餐柜操作";
            // 
            // btnCheckBoxCabinet
            // 
            this.btnCheckBoxCabinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBoxCabinet.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCheckBoxCabinet.Location = new System.Drawing.Point(100, 125);
            this.btnCheckBoxCabinet.Name = "btnCheckBoxCabinet";
            this.btnCheckBoxCabinet.Size = new System.Drawing.Size(127, 68);
            this.btnCheckBoxCabinet.TabIndex = 15;
            this.btnCheckBoxCabinet.Text = "补药";
            this.btnCheckBoxCabinet.UseVisualStyleBackColor = true;
            this.btnCheckBoxCabinet.Click += new System.EventHandler(this.btnCheckBoxCabinet_Click);
            // 
            // btnBox2
            // 
            this.btnBox2.Enabled = false;
            this.btnBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBox2.Location = new System.Drawing.Point(272, 125);
            this.btnBox2.Name = "btnBox2";
            this.btnBox2.Size = new System.Drawing.Size(127, 68);
            this.btnBox2.TabIndex = 17;
            this.btnBox2.Text = "盘点";
            this.btnBox2.UseVisualStyleBackColor = true;
            // 
            // btnNurseStoreDrug
            // 
            this.btnNurseStoreDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNurseStoreDrug.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNurseStoreDrug.Location = new System.Drawing.Point(100, 439);
            this.btnNurseStoreDrug.Name = "btnNurseStoreDrug";
            this.btnNurseStoreDrug.Size = new System.Drawing.Size(127, 68);
            this.btnNurseStoreDrug.TabIndex = 16;
            this.btnNurseStoreDrug.Text = "上药";
            this.btnNurseStoreDrug.UseVisualStyleBackColor = true;
            this.btnNurseStoreDrug.Click += new System.EventHandler(this.btnNurseStoreDrug_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenuNurse);
            this.Controls.Add(this.pnlMenuAnesthetist);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbHead)).EndInit();
            this.pnlMenuAnesthetist.ResumeLayout(false);
            this.pnlMenuNurse.ResumeLayout(false);
            this.pnlMenuNurse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.PictureBox picbHead;
        private System.Windows.Forms.TextBox txtCardLogin;
        private System.Windows.Forms.Label lblUserTitile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFasterGetOut;
        private System.Windows.Forms.Button btnPutIn;
        private System.Windows.Forms.Button btnGetOut;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel pnlMenuAnesthetist;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Panel pnlMenuNurse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGetOutDrug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnCheckBoxCabinet;
        private System.Windows.Forms.Button btnBox2;
        private System.Windows.Forms.Button btnNurseStoreDrug;
    }
}