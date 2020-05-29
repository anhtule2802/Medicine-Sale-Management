namespace PTUD_GUI
{
    partial class UCQuanLiNhanVien
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.tabpageQLNV = new System.Windows.Forms.TabControl();
            this.tabPageNVBT = new System.Windows.Forms.TabPage();
            this.dgvNVBT = new System.Windows.Forms.DataGridView();
            this.tabpageNVTK = new System.Windows.Forms.TabPage();
            this.dgvNVTK = new System.Windows.Forms.DataGridView();
            this.cboCaLamViec = new System.Windows.Forms.ComboBox();
            this.cboLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTinhTrang1 = new System.Windows.Forms.CheckBox();
            this.cbTinhTrang2 = new System.Windows.Forms.CheckBox();
            this.cbbThanhPho = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabpageQLNV.SuspendLayout();
            this.tabPageNVBT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVBT)).BeginInit();
            this.tabpageNVTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(769, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 145;
            this.label4.Text = "Danh sách nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(2, 635);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(193, 44);
            this.btnThem.TabIndex = 141;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLuu.BackColor = System.Drawing.Color.Chocolate;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(2, 680);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(383, 44);
            this.btnLuu.TabIndex = 139;
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
            this.btnSua.Location = new System.Drawing.Point(195, 635);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(190, 44);
            this.btnSua.TabIndex = 140;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(5, 410);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 38);
            this.txtEmail.TabIndex = 136;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(2, 381);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 135;
            this.label8.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(2, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 133;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(2, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 132;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoDienThoai.BackColor = System.Drawing.Color.White;
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(5, 275);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.MaxLength = 11;
            this.txtSoDienThoai.Multiline = true;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(380, 38);
            this.txtSoDienThoai.TabIndex = 131;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            this.txtSoDienThoai.Leave += new System.EventHandler(this.txtSoDienThoai_Leave);
            // 
            // rdNu
            // 
            this.rdNu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.ForeColor = System.Drawing.Color.Red;
            this.rdNu.Location = new System.Drawing.Point(181, 207);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(53, 24);
            this.rdNu.TabIndex = 128;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.ForeColor = System.Drawing.Color.Blue;
            this.rdNam.Location = new System.Drawing.Point(107, 207);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(68, 24);
            this.rdNam.TabIndex = 127;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(2, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 126;
            this.label6.Text = "Giới tính:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenNhanVien.BackColor = System.Drawing.Color.White;
            this.txtTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(163, 171);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhanVien.Multiline = true;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(222, 30);
            this.txtTenNhanVien.TabIndex = 125;
            this.txtTenNhanVien.Leave += new System.EventHandler(this.txtTenNhanVien_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(2, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 124;
            this.label7.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(445, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 39);
            this.label2.TabIndex = 123;
            this.label2.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 514);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 148;
            this.label1.Text = "Ngày làm việc";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(5, 542);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(380, 22);
            this.dtpNgay.TabIndex = 150;
            // 
            // tabpageQLNV
            // 
            this.tabpageQLNV.Controls.Add(this.tabPageNVBT);
            this.tabpageQLNV.Controls.Add(this.tabpageNVTK);
            this.tabpageQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpageQLNV.Location = new System.Drawing.Point(421, 125);
            this.tabpageQLNV.Name = "tabpageQLNV";
            this.tabpageQLNV.SelectedIndex = 0;
            this.tabpageQLNV.Size = new System.Drawing.Size(908, 599);
            this.tabpageQLNV.TabIndex = 151;
            // 
            // tabPageNVBT
            // 
            this.tabPageNVBT.Controls.Add(this.dgvNVBT);
            this.tabPageNVBT.Location = new System.Drawing.Point(4, 29);
            this.tabPageNVBT.Name = "tabPageNVBT";
            this.tabPageNVBT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNVBT.Size = new System.Drawing.Size(900, 545);
            this.tabPageNVBT.TabIndex = 0;
            this.tabPageNVBT.Text = "Nhân viên bán thuốc";
            this.tabPageNVBT.UseVisualStyleBackColor = true;
            // 
            // dgvNVBT
            // 
            this.dgvNVBT.BackgroundColor = System.Drawing.Color.White;
            this.dgvNVBT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVBT.Location = new System.Drawing.Point(0, -25);
            this.dgvNVBT.MultiSelect = false;
            this.dgvNVBT.Name = "dgvNVBT";
            this.dgvNVBT.RowTemplate.Height = 24;
            this.dgvNVBT.Size = new System.Drawing.Size(907, 553);
            this.dgvNVBT.TabIndex = 0;
            this.dgvNVBT.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNVBT_CellEnter);
            // 
            // tabpageNVTK
            // 
            this.tabpageNVTK.Controls.Add(this.dgvNVTK);
            this.tabpageNVTK.Location = new System.Drawing.Point(4, 29);
            this.tabpageNVTK.Name = "tabpageNVTK";
            this.tabpageNVTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNVTK.Size = new System.Drawing.Size(900, 566);
            this.tabpageNVTK.TabIndex = 1;
            this.tabpageNVTK.Text = "Nhân viên thống kê";
            this.tabpageNVTK.UseVisualStyleBackColor = true;
            // 
            // dgvNVTK
            // 
            this.dgvNVTK.AllowUserToAddRows = false;
            this.dgvNVTK.AllowUserToDeleteRows = false;
            this.dgvNVTK.BackgroundColor = System.Drawing.Color.White;
            this.dgvNVTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVTK.Location = new System.Drawing.Point(0, -10);
            this.dgvNVTK.MultiSelect = false;
            this.dgvNVTK.Name = "dgvNVTK";
            this.dgvNVTK.ReadOnly = true;
            this.dgvNVTK.RowTemplate.Height = 24;
            this.dgvNVTK.Size = new System.Drawing.Size(907, 559);
            this.dgvNVTK.TabIndex = 0;
            this.dgvNVTK.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNVTK_CellEnter);
            // 
            // cboCaLamViec
            // 
            this.cboCaLamViec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCaLamViec.BackColor = System.Drawing.Color.White;
            this.cboCaLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaLamViec.ForeColor = System.Drawing.Color.Maroon;
            this.cboCaLamViec.FormattingEnabled = true;
            this.cboCaLamViec.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.cboCaLamViec.Location = new System.Drawing.Point(284, 469);
            this.cboCaLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.cboCaLamViec.Name = "cboCaLamViec";
            this.cboCaLamViec.Size = new System.Drawing.Size(101, 33);
            this.cboCaLamViec.TabIndex = 138;
            // 
            // cboLoaiNhanVien
            // 
            this.cboLoaiNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLoaiNhanVien.BackColor = System.Drawing.Color.White;
            this.cboLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiNhanVien.ForeColor = System.Drawing.Color.Maroon;
            this.cboLoaiNhanVien.FormattingEnabled = true;
            this.cboLoaiNhanVien.Items.AddRange(new object[] {
            "Nhân viên bán thuốc",
            "Nhân viên thống kê"});
            this.cboLoaiNhanVien.Location = new System.Drawing.Point(7, 469);
            this.cboLoaiNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            this.cboLoaiNhanVien.Size = new System.Drawing.Size(269, 33);
            this.cboLoaiNhanVien.TabIndex = 137;
            this.cboLoaiNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboLoaiNhanVien_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(2, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 152;
            this.label9.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(163, 125);
            this.txtMaNhanVien.Multiline = true;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(222, 34);
            this.txtMaNhanVien.TabIndex = 153;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(2, 588);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 154;
            this.label10.Text = "Tình trạng:";
            // 
            // cbTinhTrang1
            // 
            this.cbTinhTrang1.AutoSize = true;
            this.cbTinhTrang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang1.ForeColor = System.Drawing.Color.Maroon;
            this.cbTinhTrang1.Location = new System.Drawing.Point(117, 589);
            this.cbTinhTrang1.Name = "cbTinhTrang1";
            this.cbTinhTrang1.Size = new System.Drawing.Size(140, 24);
            this.cbTinhTrang1.TabIndex = 155;
            this.cbTinhTrang1.Text = "Còn làm việc";
            this.cbTinhTrang1.UseVisualStyleBackColor = true;
            this.cbTinhTrang1.CheckedChanged += new System.EventHandler(this.cbTinhTrang1_CheckedChanged);
            // 
            // cbTinhTrang2
            // 
            this.cbTinhTrang2.AutoSize = true;
            this.cbTinhTrang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang2.ForeColor = System.Drawing.Color.Maroon;
            this.cbTinhTrang2.Location = new System.Drawing.Point(254, 588);
            this.cbTinhTrang2.Name = "cbTinhTrang2";
            this.cbTinhTrang2.Size = new System.Drawing.Size(131, 24);
            this.cbTinhTrang2.TabIndex = 156;
            this.cbTinhTrang2.Text = "Đã thôi việc";
            this.cbTinhTrang2.UseVisualStyleBackColor = true;
            this.cbTinhTrang2.CheckedChanged += new System.EventHandler(this.cbTinhTrang2_CheckedChanged);
            // 
            // cbbThanhPho
            // 
            this.cbbThanhPho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbThanhPho.BackColor = System.Drawing.Color.White;
            this.cbbThanhPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThanhPho.ForeColor = System.Drawing.Color.Maroon;
            this.cbbThanhPho.FormattingEnabled = true;
            this.cbbThanhPho.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.cbbThanhPho.Location = new System.Drawing.Point(2, 344);
            this.cbbThanhPho.Margin = new System.Windows.Forms.Padding(4);
            this.cbbThanhPho.Name = "cbbThanhPho";
            this.cbbThanhPho.Size = new System.Drawing.Size(380, 33);
            this.cbbThanhPho.TabIndex = 149;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCQuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbTinhTrang2);
            this.Controls.Add(this.cbTinhTrang1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabpageQLNV);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.cbbThanhPho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cboCaLamViec);
            this.Controls.Add(this.cboLoaiNhanVien);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQuanLiNhanVien";
            this.Size = new System.Drawing.Size(1331, 762);
            this.tabpageQLNV.ResumeLayout(false);
            this.tabPageNVBT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVBT)).EndInit();
            this.tabpageNVTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TabControl tabpageQLNV;
        private System.Windows.Forms.TabPage tabPageNVBT;
        private System.Windows.Forms.TabPage tabpageNVTK;
        private System.Windows.Forms.DataGridView dgvNVTK;
        private System.Windows.Forms.ComboBox cboCaLamViec;
        private System.Windows.Forms.ComboBox cboLoaiNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbTinhTrang1;
        private System.Windows.Forms.CheckBox cbTinhTrang2;
        private System.Windows.Forms.DataGridView dgvNVBT;
        private System.Windows.Forms.ComboBox cbbThanhPho;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
