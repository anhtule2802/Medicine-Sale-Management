namespace PTUD_GUI
{
    partial class FormDSDT
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dgvDSDT = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTDT = new System.Windows.Forms.DataGridView();
            this.tbTimKiemDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDate.Location = new System.Drawing.Point(242, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 20);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "dd/MM/yyyy";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(553, 60);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 38);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(16, 577);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(576, 37);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dgvDSDT
            // 
            this.dgvDSDT.AllowUserToAddRows = false;
            this.dgvDSDT.AllowUserToDeleteRows = false;
            this.dgvDSDT.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDSDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDT.Location = new System.Drawing.Point(16, 104);
            this.dgvDSDT.MultiSelect = false;
            this.dgvDSDT.Name = "dgvDSDT";
            this.dgvDSDT.ReadOnly = true;
            this.dgvDSDT.Size = new System.Drawing.Size(576, 221);
            this.dgvDSDT.TabIndex = 24;
            this.dgvDSDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDT_CellClick);
            this.dgvDSDT.DoubleClick += new System.EventHandler(this.dgvDSDT_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(127, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 38);
            this.label4.TabIndex = 23;
            this.label4.Text = "Danh sách đơn thuốc";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 610);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 620);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 10);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 10);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(598, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 630);
            this.panel1.TabIndex = 19;
            // 
            // dgvCTDT
            // 
            this.dgvCTDT.AllowUserToAddRows = false;
            this.dgvCTDT.AllowUserToDeleteRows = false;
            this.dgvCTDT.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDT.Enabled = false;
            this.dgvCTDT.Location = new System.Drawing.Point(16, 331);
            this.dgvCTDT.MultiSelect = false;
            this.dgvCTDT.Name = "dgvCTDT";
            this.dgvCTDT.ReadOnly = true;
            this.dgvCTDT.Size = new System.Drawing.Size(576, 240);
            this.dgvCTDT.TabIndex = 28;
            // 
            // tbTimKiemDT
            // 
            this.tbTimKiemDT.Location = new System.Drawing.Point(201, 76);
            this.tbTimKiemDT.Name = "tbTimKiemDT";
            this.tbTimKiemDT.Size = new System.Drawing.Size(207, 20);
            this.tbTimKiemDT.TabIndex = 29;
            this.tbTimKiemDT.TextChanged += new System.EventHandler(this.tbTimKiemDT_TextChanged);
            this.tbTimKiemDT.Enter += new System.EventHandler(this.tbTimKiemDT_Enter);
            this.tbTimKiemDT.Leave += new System.EventHandler(this.tbTimKiemDT_Leave);
            // 
            // FormDSDT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 630);
            this.Controls.Add(this.tbTimKiemDT);
            this.Controls.Add(this.dgvCTDT);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dgvDSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDSDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDSDT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvDSDT;
        public System.Windows.Forms.DataGridView dgvCTDT;
        private System.Windows.Forms.TextBox tbTimKiemDT;
    }
}