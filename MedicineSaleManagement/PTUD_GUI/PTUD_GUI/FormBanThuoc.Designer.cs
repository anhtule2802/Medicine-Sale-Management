namespace PTUD_GUI
{
    partial class FormBanThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanThuoc));
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDSHD = new System.Windows.Forms.Button();
            this.btnTrangChinh = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnBanThuocKeDon = new System.Windows.Forms.Button();
            this.btnBanThuocKhongKeDon = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.dragControl1 = new PTUD_GUI.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelSide.Location = new System.Drawing.Point(0, 99);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 50);
            this.panelSide.TabIndex = 3;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(10, 323);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(190, 50);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "   Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDSHD
            // 
            this.btnDSHD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDSHD.FlatAppearance.BorderSize = 0;
            this.btnDSHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHD.ForeColor = System.Drawing.Color.White;
            this.btnDSHD.Image = ((System.Drawing.Image)(resources.GetObject("btnDSHD.Image")));
            this.btnDSHD.Location = new System.Drawing.Point(10, 267);
            this.btnDSHD.Name = "btnDSHD";
            this.btnDSHD.Size = new System.Drawing.Size(190, 50);
            this.btnDSHD.TabIndex = 8;
            this.btnDSHD.Text = "   Danh sách\r\nhóa đơn";
            this.btnDSHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSHD.UseVisualStyleBackColor = false;
            this.btnDSHD.Click += new System.EventHandler(this.btnDSHD_Click);
            // 
            // btnTrangChinh
            // 
            this.btnTrangChinh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTrangChinh.FlatAppearance.BorderSize = 0;
            this.btnTrangChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChinh.ForeColor = System.Drawing.Color.White;
            this.btnTrangChinh.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChinh.Image")));
            this.btnTrangChinh.Location = new System.Drawing.Point(10, 99);
            this.btnTrangChinh.Name = "btnTrangChinh";
            this.btnTrangChinh.Size = new System.Drawing.Size(190, 50);
            this.btnTrangChinh.TabIndex = 4;
            this.btnTrangChinh.Text = "   Trang chính";
            this.btnTrangChinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChinh.UseVisualStyleBackColor = false;
            this.btnTrangChinh.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMenu.Location = new System.Drawing.Point(155, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(44, 45);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "NHÂN VIÊN BÁN THUỐC";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(843, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(122, 25);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnMenu);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 100);
            this.panel5.TabIndex = 6;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLeft.Controls.Add(this.btnBanThuocKeDon);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnBanThuocKhongKeDon);
            this.panelLeft.Controls.Add(this.btnDangXuat);
            this.panelLeft.Controls.Add(this.btnDSHD);
            this.panelLeft.Controls.Add(this.btnTrangChinh);
            this.panelLeft.Controls.Add(this.panel5);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(202, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // btnBanThuocKeDon
            // 
            this.btnBanThuocKeDon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBanThuocKeDon.FlatAppearance.BorderSize = 0;
            this.btnBanThuocKeDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanThuocKeDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanThuocKeDon.ForeColor = System.Drawing.Color.White;
            this.btnBanThuocKeDon.Image = ((System.Drawing.Image)(resources.GetObject("btnBanThuocKeDon.Image")));
            this.btnBanThuocKeDon.Location = new System.Drawing.Point(10, 155);
            this.btnBanThuocKeDon.Name = "btnBanThuocKeDon";
            this.btnBanThuocKeDon.Size = new System.Drawing.Size(190, 50);
            this.btnBanThuocKeDon.TabIndex = 10;
            this.btnBanThuocKeDon.Text = "   Bán thuốc\r\n   kê đơn";
            this.btnBanThuocKeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanThuocKeDon.UseVisualStyleBackColor = false;
            this.btnBanThuocKeDon.Click += new System.EventHandler(this.btnBanThuocKeDon_Click);
            // 
            // btnBanThuocKhongKeDon
            // 
            this.btnBanThuocKhongKeDon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBanThuocKhongKeDon.FlatAppearance.BorderSize = 0;
            this.btnBanThuocKhongKeDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanThuocKhongKeDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanThuocKhongKeDon.ForeColor = System.Drawing.Color.White;
            this.btnBanThuocKhongKeDon.Image = ((System.Drawing.Image)(resources.GetObject("btnBanThuocKhongKeDon.Image")));
            this.btnBanThuocKhongKeDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanThuocKhongKeDon.Location = new System.Drawing.Point(10, 211);
            this.btnBanThuocKhongKeDon.Name = "btnBanThuocKhongKeDon";
            this.btnBanThuocKhongKeDon.Size = new System.Drawing.Size(190, 50);
            this.btnBanThuocKhongKeDon.TabIndex = 7;
            this.btnBanThuocKhongKeDon.Text = " Bán thuốc\r\n    không kê đơn";
            this.btnBanThuocKhongKeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanThuocKhongKeDon.UseVisualStyleBackColor = false;
            this.btnBanThuocKhongKeDon.Click += new System.EventHandler(this.btnBanThuoc_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.lblTen);
            this.panel4.Controls.Add(this.lblMa);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.labelTime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(202, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(998, 52);
            this.panel4.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(92, 16);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(70, 25);
            this.lblTen.TabIndex = 8;
            this.lblTen.Text = "label2";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.White;
            this.lblMa.Location = new System.Drawing.Point(62, 16);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(24, 25);
            this.lblMa.TabIndex = 7;
            this.lblMa.Text = "1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 100);
            this.panel3.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnShutDown);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.panel3);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(202, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(998, 49);
            this.panelHeader.TabIndex = 1;
            // 
            // btnShutDown
            // 
            this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutDown.BackColor = System.Drawing.Color.White;
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.Color.White;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.Location = new System.Drawing.Point(949, 0);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(49, 46);
            this.btnShutDown.TabIndex = 16;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.buttonShutDown_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(202, 101);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(998, 619);
            this.panelControl.TabIndex = 3;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // FormBanThuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTrangChinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDSHD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnBanThuocKeDon;
        private System.Windows.Forms.Button btnBanThuocKhongKeDon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DragControl dragControl1;
        public System.Windows.Forms.Label lblTen;
        public System.Windows.Forms.Label lblMa;
    }
}

