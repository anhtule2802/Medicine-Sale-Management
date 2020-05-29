namespace PTUD_GUI
{
    partial class FormDSBN
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
            this.dgvDSBN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTimKiemBN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSBN
            // 
            this.dgvDSBN.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBN.Location = new System.Drawing.Point(16, 80);
            this.dgvDSBN.MultiSelect = false;
            this.dgvDSBN.Name = "dgvDSBN";
            this.dgvDSBN.Size = new System.Drawing.Size(481, 311);
            this.dgvDSBN.TabIndex = 0;
            this.dgvDSBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBN_CellClick);
            this.dgvDSBN.DoubleClick += new System.EventHandler(this.dgvDSBN_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Bệnh Nhân Cũ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chọn Bệnh Nhân";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTimKiemBN
            // 
            this.tbTimKiemBN.Location = new System.Drawing.Point(162, 52);
            this.tbTimKiemBN.Name = "tbTimKiemBN";
            this.tbTimKiemBN.Size = new System.Drawing.Size(187, 20);
            this.tbTimKiemBN.TabIndex = 3;
            this.tbTimKiemBN.TextChanged += new System.EventHandler(this.tbTimKiemBN_TextChanged);
            this.tbTimKiemBN.Enter += new System.EventHandler(this.tbTimKiemBN_Enter_1);
            this.tbTimKiemBN.Leave += new System.EventHandler(this.tbTimKiemBN_Leave_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 10);
            this.panel2.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 436);
            this.panel4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(503, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 436);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 10);
            this.panel3.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(413, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 26;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDSBN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(513, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbTimKiemBN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDSBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDSBN";
            this.Load += new System.EventHandler(this.FormDSBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvDSBN;
        private System.Windows.Forms.TextBox tbTimKiemBN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
    }
}