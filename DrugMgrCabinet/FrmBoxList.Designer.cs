namespace DrugMgrCabinet
{
    partial class FrmBoxList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFootInformation = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSetBox = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnBox1 = new System.Windows.Forms.Button();
            this.btnBox2 = new System.Windows.Forms.Button();
            this.btnBox3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlFootInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlFootInformation);
            this.panel1.Controls.Add(this.lblInformation);
            this.panel1.Controls.Add(this.btnBox1);
            this.panel1.Controls.Add(this.btnBox2);
            this.panel1.Controls.Add(this.btnBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 624);
            this.panel1.TabIndex = 17;
            // 
            // pnlFootInformation
            // 
            this.pnlFootInformation.Controls.Add(this.label1);
            this.pnlFootInformation.Controls.Add(this.lblSetBox);
            this.pnlFootInformation.Location = new System.Drawing.Point(99, 539);
            this.pnlFootInformation.Name = "pnlFootInformation";
            this.pnlFootInformation.Size = new System.Drawing.Size(485, 46);
            this.pnlFootInformation.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "点击快速取箱，自动提供";
            // 
            // lblSetBox
            // 
            this.lblSetBox.AutoSize = true;
            this.lblSetBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSetBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblSetBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSetBox.Location = new System.Drawing.Point(209, 11);
            this.lblSetBox.Name = "lblSetBox";
            this.lblSetBox.Size = new System.Drawing.Size(74, 21);
            this.lblSetBox.TabIndex = 16;
            this.lblSetBox.Text = "箱子名称";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInformation.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lblInformation.Location = new System.Drawing.Point(123, 70);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(182, 31);
            this.lblInformation.TabIndex = 14;
            this.lblInformation.Text = "请选择麻醉药箱";
            // 
            // btnBox1
            // 
            this.btnBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBox1.Location = new System.Drawing.Point(129, 188);
            this.btnBox1.Name = "btnBox1";
            this.btnBox1.Size = new System.Drawing.Size(127, 68);
            this.btnBox1.TabIndex = 9;
            this.btnBox1.Text = "心脏瓣膜麻醉药箱";
            this.btnBox1.UseVisualStyleBackColor = true;
            // 
            // btnBox2
            // 
            this.btnBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBox2.Location = new System.Drawing.Point(331, 188);
            this.btnBox2.Name = "btnBox2";
            this.btnBox2.Size = new System.Drawing.Size(127, 68);
            this.btnBox2.TabIndex = 12;
            this.btnBox2.Text = "人工流产麻醉药箱";
            this.btnBox2.UseVisualStyleBackColor = true;
            // 
            // btnBox3
            // 
            this.btnBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBox3.Location = new System.Drawing.Point(129, 300);
            this.btnBox3.Name = "btnBox3";
            this.btnBox3.Size = new System.Drawing.Size(127, 68);
            this.btnBox3.TabIndex = 11;
            this.btnBox3.Text = "普通药箱";
            this.btnBox3.UseVisualStyleBackColor = true;
            // 
            // FrmBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 624);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(370, 80);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBoxList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmGetOutBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFootInformation.ResumeLayout(false);
            this.pnlFootInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnBox1;
        private System.Windows.Forms.Button btnBox2;
        private System.Windows.Forms.Button btnBox3;
        private System.Windows.Forms.Label lblSetBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFootInformation;

    }
}