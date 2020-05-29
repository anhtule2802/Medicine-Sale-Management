namespace PTUD_GUI
{
    partial class UCThongKeDoanhThu
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
            this.dgvTKDoanhThu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageThongKeDoanhThu = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTKNhapThuoc = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTKThuocToiHan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDoanhThu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageThongKeDoanhThu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNhapThuoc)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKThuocToiHan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTKDoanhThu
            // 
            this.dgvTKDoanhThu.AllowUserToAddRows = false;
            this.dgvTKDoanhThu.AllowUserToDeleteRows = false;
            this.dgvTKDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvTKDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKDoanhThu.Location = new System.Drawing.Point(1, 1);
            this.dgvTKDoanhThu.Name = "dgvTKDoanhThu";
            this.dgvTKDoanhThu.ReadOnly = true;
            this.dgvTKDoanhThu.Size = new System.Drawing.Size(978, 443);
            this.dgvTKDoanhThu.TabIndex = 142;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 149;
            this.label6.Text = "Ngày:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(491, 31);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(92, 16);
            this.lblNgay.TabIndex = 148;
            this.lblNgay.Text = "dd/MM/yyyy";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(445, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 147;
            this.label1.Text = "THỐNG KÊ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageThongKeDoanhThu);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 482);
            this.tabControl1.TabIndex = 146;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageThongKeDoanhThu
            // 
            this.tabPageThongKeDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageThongKeDoanhThu.Controls.Add(this.dgvTKDoanhThu);
            this.tabPageThongKeDoanhThu.Location = new System.Drawing.Point(4, 29);
            this.tabPageThongKeDoanhThu.Name = "tabPageThongKeDoanhThu";
            this.tabPageThongKeDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongKeDoanhThu.Size = new System.Drawing.Size(984, 449);
            this.tabPageThongKeDoanhThu.TabIndex = 0;
            this.tabPageThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.tabPageThongKeDoanhThu.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.dgvTKNhapThuoc);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê nhập thuốc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTKNhapThuoc
            // 
            this.dgvTKNhapThuoc.AllowUserToAddRows = false;
            this.dgvTKNhapThuoc.AllowUserToDeleteRows = false;
            this.dgvTKNhapThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvTKNhapThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKNhapThuoc.Location = new System.Drawing.Point(1, 1);
            this.dgvTKNhapThuoc.Name = "dgvTKNhapThuoc";
            this.dgvTKNhapThuoc.ReadOnly = true;
            this.dgvTKNhapThuoc.Size = new System.Drawing.Size(978, 443);
            this.dgvTKNhapThuoc.TabIndex = 143;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTKThuocToiHan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 449);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thống Kê Thuốc Tới Hạn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTKThuocToiHan
            // 
            this.dgvTKThuocToiHan.AllowUserToAddRows = false;
            this.dgvTKThuocToiHan.AllowUserToDeleteRows = false;
            this.dgvTKThuocToiHan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTKThuocToiHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKThuocToiHan.Location = new System.Drawing.Point(3, 3);
            this.dgvTKThuocToiHan.Name = "dgvTKThuocToiHan";
            this.dgvTKThuocToiHan.ReadOnly = true;
            this.dgvTKThuocToiHan.Size = new System.Drawing.Size(978, 443);
            this.dgvTKThuocToiHan.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 152;
            this.label2.Text = "Từ Ngày:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(351, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 154;
            this.label3.Text = "Đến Ngày:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 155;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(50, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 156;
            this.label4.Text = "Tổng Tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(169, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 157;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 158;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(449, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 159;
            // 
            // UCThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "UCThongKeDoanhThu";
            this.Size = new System.Drawing.Size(998, 619);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDoanhThu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageThongKeDoanhThu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNhapThuoc)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKThuocToiHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTKDoanhThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageThongKeDoanhThu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTKNhapThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTKThuocToiHan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
