namespace PTUD_GUI
{
    partial class FormQuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnQuanLiThuoc = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnQuanLiLoThuoc = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLiNhanVien = new System.Windows.Forms.Button();
            this.btnTrangChinh = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.dragControl1 = new PTUD_GUI.DragControl();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panelControl, "panelControl");
            this.panelControl.Name = "panelControl";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.lblMa);
            this.panel4.Controls.Add(this.lblTen);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.labelTime);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lblMa
            // 
            resources.ApplyResources(this.lblMa, "lblMa");
            this.lblMa.ForeColor = System.Drawing.Color.White;
            this.lblMa.Name = "lblMa";
            // 
            // lblTen
            // 
            resources.ApplyResources(this.lblTen, "lblTen");
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Name = "lblTen";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // labelTime
            // 
            resources.ApplyResources(this.labelTime, "labelTime");
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Name = "labelTime";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnShutDown);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.panel3);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            // 
            // btnShutDown
            // 
            resources.ApplyResources(this.btnShutDown, "btnShutDown");
            this.btnShutDown.BackColor = System.Drawing.Color.White;
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShutDown.ForeColor = System.Drawing.Color.White;
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Name = "label2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLeft.Controls.Add(this.btnQuanLiThuoc);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnQuanLiLoThuoc);
            this.panelLeft.Controls.Add(this.btnDangXuat);
            this.panelLeft.Controls.Add(this.btnQuanLiNhanVien);
            this.panelLeft.Controls.Add(this.btnTrangChinh);
            this.panelLeft.Controls.Add(this.panel5);
            resources.ApplyResources(this.panelLeft, "panelLeft");
            this.panelLeft.Name = "panelLeft";
            // 
            // btnQuanLiThuoc
            // 
            this.btnQuanLiThuoc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuanLiThuoc.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnQuanLiThuoc, "btnQuanLiThuoc");
            this.btnQuanLiThuoc.ForeColor = System.Drawing.Color.White;
            this.btnQuanLiThuoc.Name = "btnQuanLiThuoc";
            this.btnQuanLiThuoc.UseVisualStyleBackColor = false;
            this.btnQuanLiThuoc.Click += new System.EventHandler(this.btnQuanLiThuoc_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.MediumSpringGreen;
            resources.ApplyResources(this.panelSide, "panelSide");
            this.panelSide.Name = "panelSide";
            // 
            // btnQuanLiLoThuoc
            // 
            this.btnQuanLiLoThuoc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuanLiLoThuoc.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnQuanLiLoThuoc, "btnQuanLiLoThuoc");
            this.btnQuanLiLoThuoc.ForeColor = System.Drawing.Color.White;
            this.btnQuanLiLoThuoc.Name = "btnQuanLiLoThuoc";
            this.btnQuanLiLoThuoc.UseVisualStyleBackColor = false;
            this.btnQuanLiLoThuoc.Click += new System.EventHandler(this.btnQuanLiLoThuoc_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDangXuat, "btnDangXuat");
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanLiNhanVien
            // 
            this.btnQuanLiNhanVien.AutoEllipsis = true;
            this.btnQuanLiNhanVien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuanLiNhanVien.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnQuanLiNhanVien, "btnQuanLiNhanVien");
            this.btnQuanLiNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLiNhanVien.Name = "btnQuanLiNhanVien";
            this.btnQuanLiNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLiNhanVien.Click += new System.EventHandler(this.btnQuanLiNhanVien_Click);
            // 
            // btnTrangChinh
            // 
            this.btnTrangChinh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTrangChinh.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTrangChinh, "btnTrangChinh");
            this.btnTrangChinh.ForeColor = System.Drawing.Color.White;
            this.btnTrangChinh.Name = "btnTrangChinh";
            this.btnTrangChinh.UseVisualStyleBackColor = false;
            this.btnTrangChinh.Click += new System.EventHandler(this.btnTrangChinh_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnMenu);
            this.panel5.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // FormQuanLy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLy";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnQuanLiThuoc;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnQuanLiLoThuoc;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLiNhanVien;
        private System.Windows.Forms.Button btnTrangChinh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private DragControl dragControl1;
        public System.Windows.Forms.Label lblMa;
        public System.Windows.Forms.Label lblTen;
    }
}