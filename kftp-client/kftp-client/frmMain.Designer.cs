namespace kftp_client
{
    partial class frmMain
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
            this.grpKetNoi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMayChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tLocal = new System.Windows.Forms.TreeView();
            this.tRemote = new System.Windows.Forms.TreeView();
            this.rTxtLog = new System.Windows.Forms.RichTextBox();
            this.grpKetNoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKetNoi
            // 
            this.grpKetNoi.Controls.Add(this.btnKetNoi);
            this.grpKetNoi.Controls.Add(this.txtPort);
            this.grpKetNoi.Controls.Add(this.txtMatKhau);
            this.grpKetNoi.Controls.Add(this.txtTaiKhoan);
            this.grpKetNoi.Controls.Add(this.label4);
            this.grpKetNoi.Controls.Add(this.label3);
            this.grpKetNoi.Controls.Add(this.label2);
            this.grpKetNoi.Controls.Add(this.txtMayChu);
            this.grpKetNoi.Controls.Add(this.label1);
            this.grpKetNoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKetNoi.Location = new System.Drawing.Point(0, 0);
            this.grpKetNoi.Name = "grpKetNoi";
            this.grpKetNoi.Size = new System.Drawing.Size(816, 53);
            this.grpKetNoi.TabIndex = 0;
            this.grpKetNoi.TabStop = false;
            this.grpKetNoi.Text = "Kết nối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máy chủ:";
            // 
            // txtMayChu
            // 
            this.txtMayChu.Location = new System.Drawing.Point(63, 21);
            this.txtMayChu.Name = "txtMayChu";
            this.txtMayChu.Size = new System.Drawing.Size(120, 20);
            this.txtMayChu.TabIndex = 1;
            this.txtMayChu.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(253, 21);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(120, 20);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(440, 21);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(120, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cổng:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(607, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "21";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(670, 19);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoi.TabIndex = 2;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tLocal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tRemote);
            this.splitContainer1.Size = new System.Drawing.Size(816, 324);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 1;
            // 
            // tLocal
            // 
            this.tLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLocal.Location = new System.Drawing.Point(0, 0);
            this.tLocal.Name = "tLocal";
            this.tLocal.Size = new System.Drawing.Size(425, 324);
            this.tLocal.TabIndex = 0;
            // 
            // tRemote
            // 
            this.tRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tRemote.Location = new System.Drawing.Point(0, 0);
            this.tRemote.Name = "tRemote";
            this.tRemote.Size = new System.Drawing.Size(387, 324);
            this.tRemote.TabIndex = 0;
            // 
            // rTxtLog
            // 
            this.rTxtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rTxtLog.Location = new System.Drawing.Point(0, 377);
            this.rTxtLog.Name = "rTxtLog";
            this.rTxtLog.Size = new System.Drawing.Size(816, 135);
            this.rTxtLog.TabIndex = 2;
            this.rTxtLog.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 512);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grpKetNoi);
            this.Controls.Add(this.rTxtLog);
            this.Name = "frmMain";
            this.Text = "kFTP Client";
            this.grpKetNoi.ResumeLayout(false);
            this.grpKetNoi.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKetNoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMayChu;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tLocal;
        private System.Windows.Forms.TreeView tRemote;
        private System.Windows.Forms.RichTextBox rTxtLog;
    }
}

