namespace PTUD_GUI
{
    partial class UCQuanLiLoThuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDVT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrSL = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoTinhTrang1 = new System.Windows.Forms.RadioButton();
            this.rdoTinhTrang2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(4, 549);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(253, 44);
            this.btnThem.TabIndex = 110;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLuu.BackColor = System.Drawing.Color.Chocolate;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(4, 598);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(533, 44);
            this.btnLuu.TabIndex = 108;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSua.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(265, 549);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(272, 44);
            this.btnSua.TabIndex = 109;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(843, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 107;
            this.label3.Text = "Danh sách lô thuốc";
            // 
            // cboLoaiThuoc
            // 
            this.cboLoaiThuoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLoaiThuoc.BackColor = System.Drawing.Color.White;
            this.cboLoaiThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiThuoc.ForeColor = System.Drawing.Color.Black;
            this.cboLoaiThuoc.FormattingEnabled = true;
            this.cboLoaiThuoc.Location = new System.Drawing.Point(4, 151);
            this.cboLoaiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiThuoc.Name = "cboLoaiThuoc";
            this.cboLoaiThuoc.Size = new System.Drawing.Size(533, 33);
            this.cboLoaiThuoc.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(4, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Tên thuốc:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(425, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 39);
            this.label2.TabIndex = 103;
            this.label2.Text = "QUẢN LÍ LÔ THUỐC";
            // 
            // txtMaLoThuoc
            // 
            this.txtMaLoThuoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaLoThuoc.BackColor = System.Drawing.Color.White;
            this.txtMaLoThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoThuoc.Location = new System.Drawing.Point(4, 214);
            this.txtMaLoThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoThuoc.Name = "txtMaLoThuoc";
            this.txtMaLoThuoc.ReadOnly = true;
            this.txtMaLoThuoc.Size = new System.Drawing.Size(253, 30);
            this.txtMaLoThuoc.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(4, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Mã lô:";
            // 
            // dgvDanhSachThuoc
            // 
            this.dgvDanhSachThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThuoc.Location = new System.Drawing.Point(559, 128);
            this.dgvDanhSachThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachThuoc.MultiSelect = false;
            this.dgvDanhSachThuoc.Name = "dgvDanhSachThuoc";
            this.dgvDanhSachThuoc.Size = new System.Drawing.Size(768, 514);
            this.dgvDanhSachThuoc.TabIndex = 112;
            this.dgvDanhSachThuoc.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThuoc_CellEnter);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(276, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 150;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // cbbNCC
            // 
            this.cbbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(280, 213);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(257, 24);
            this.cbbNCC.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(4, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 152;
            this.label5.Text = "Đơn vị tính:";
            // 
            // cbbDVT
            // 
            this.cbbDVT.FormattingEnabled = true;
            this.cbbDVT.Items.AddRange(new object[] {
            "Hop",
            "Vi",
            "Vien",
            "Ong"});
            this.cbbDVT.Location = new System.Drawing.Point(4, 271);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(253, 24);
            this.cbbDVT.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(276, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 154;
            this.label6.Text = "Số lượng:";
            // 
            // nmrSL
            // 
            this.nmrSL.Location = new System.Drawing.Point(280, 273);
            this.nmrSL.Name = "nmrSL";
            this.nmrSL.Size = new System.Drawing.Size(257, 22);
            this.nmrSL.TabIndex = 155;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(4, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 156;
            this.label8.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(4, 347);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(253, 22);
            this.dtpNgayNhap.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(276, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 158;
            this.label9.Text = "Ngày hết hạn:";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Location = new System.Drawing.Point(280, 347);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(257, 22);
            this.dtpNgayHetHan.TabIndex = 159;
            this.dtpNgayHetHan.ValueChanged += new System.EventHandler(this.dtpNgayHetHan_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(4, 388);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 160;
            this.label10.Text = "Tình trạng:";
            // 
            // rdoTinhTrang1
            // 
            this.rdoTinhTrang1.AutoSize = true;
            this.rdoTinhTrang1.Checked = true;
            this.rdoTinhTrang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTinhTrang1.ForeColor = System.Drawing.Color.Maroon;
            this.rdoTinhTrang1.Location = new System.Drawing.Point(129, 386);
            this.rdoTinhTrang1.Name = "rdoTinhTrang1";
            this.rdoTinhTrang1.Size = new System.Drawing.Size(171, 24);
            this.rdoTinhTrang1.TabIndex = 161;
            this.rdoTinhTrang1.TabStop = true;
            this.rdoTinhTrang1.Text = "Còn hạn sử dụng";
            this.rdoTinhTrang1.UseVisualStyleBackColor = true;
            // 
            // rdoTinhTrang2
            // 
            this.rdoTinhTrang2.AutoSize = true;
            this.rdoTinhTrang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTinhTrang2.ForeColor = System.Drawing.Color.Maroon;
            this.rdoTinhTrang2.Location = new System.Drawing.Point(369, 386);
            this.rdoTinhTrang2.Name = "rdoTinhTrang2";
            this.rdoTinhTrang2.Size = new System.Drawing.Size(168, 24);
            this.rdoTinhTrang2.TabIndex = 162;
            this.rdoTinhTrang2.Text = "Hết hạn sử dụng";
            this.rdoTinhTrang2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(4, 444);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 163;
            this.label11.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(108, 433);
            this.txtGiaBan.Multiline = true;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(149, 31);
            this.txtGiaBan.TabIndex = 164;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtGiaBan.Leave += new System.EventHandler(this.txtGiaBan_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCQuanLiLoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdoTinhTrang2);
            this.Controls.Add(this.rdoTinhTrang1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmrSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbDVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDanhSachThuoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboLoaiThuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLoThuoc);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQuanLiLoThuoc";
            this.Size = new System.Drawing.Size(1331, 762);
            this.Load += new System.EventHandler(this.UCQuanLiLoThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoaiThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDanhSachThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmrSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdoTinhTrang1;
        private System.Windows.Forms.RadioButton rdoTinhTrang2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
