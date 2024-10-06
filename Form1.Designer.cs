namespace Lab5_Entity
{
    partial class Form1
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
            this.clDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.clKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblQL = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.GRPQL = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GRPQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // clDiem
            // 
            this.clDiem.HeaderText = "Điểm TB";
            this.clDiem.MinimumWidth = 6;
            this.clDiem.Name = "clDiem";
            this.clDiem.Width = 125;
            // 
            // clTen
            // 
            this.clTen.HeaderText = "Họ Tên";
            this.clTen.MinimumWidth = 6;
            this.clTen.Name = "clTen";
            this.clTen.Width = 200;
            // 
            // clMa
            // 
            this.clMa.HeaderText = "MSSV";
            this.clMa.MinimumWidth = 6;
            this.clMa.Name = "clMa";
            this.clMa.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 459);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // clKhoa
            // 
            this.clKhoa.HeaderText = "Khoa";
            this.clKhoa.MinimumWidth = 6;
            this.clKhoa.Name = "clKhoa";
            this.clKhoa.Width = 125;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "CNTT",
            "QTKD"});
            this.cmbKhoa.Location = new System.Drawing.Point(153, 167);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(100, 24);
            this.cmbKhoa.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(153, 115);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 11;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(153, 222);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 22);
            this.txtDTB.TabIndex = 10;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(153, 58);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 22);
            this.txtMSSV.TabIndex = 9;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(403, 459);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(64, 228);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(38, 16);
            this.lblDiem.TabIndex = 8;
            this.lblDiem.Text = "DTB:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(64, 176);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(41, 16);
            this.lblKhoa.TabIndex = 7;
            this.lblKhoa.Text = "Khoa:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(64, 121);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(55, 16);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(64, 64);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(48, 16);
            this.lblMSSV.TabIndex = 5;
            this.lblMSSV.Text = "MSSV:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1190, 500);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTen,
            this.clKhoa,
            this.clDiem});
            this.dataGridView1.Location = new System.Drawing.Point(660, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 347);
            this.dataGridView1.TabIndex = 33;
            // 
            // lblQL
            // 
            this.lblQL.AutoSize = true;
            this.lblQL.Location = new System.Drawing.Point(562, 47);
            this.lblQL.Name = "lblQL";
            this.lblQL.Size = new System.Drawing.Size(211, 16);
            this.lblQL.TabIndex = 32;
            this.lblQL.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(255, 459);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // GRPQL
            // 
            this.GRPQL.Controls.Add(this.cmbKhoa);
            this.GRPQL.Controls.Add(this.txtHoTen);
            this.GRPQL.Controls.Add(this.txtDTB);
            this.GRPQL.Controls.Add(this.txtMSSV);
            this.GRPQL.Controls.Add(this.lblDiem);
            this.GRPQL.Controls.Add(this.lblKhoa);
            this.GRPQL.Controls.Add(this.lblHoTen);
            this.GRPQL.Controls.Add(this.lblMSSV);
            this.GRPQL.Location = new System.Drawing.Point(77, 89);
            this.GRPQL.Name = "GRPQL";
            this.GRPQL.Size = new System.Drawing.Size(471, 347);
            this.GRPQL.TabIndex = 29;
            this.GRPQL.TabStop = false;
            this.GRPQL.Text = "Thông tin sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 571);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblQL);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.GRPQL);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GRPQL.ResumeLayout(false);
            this.GRPQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblQL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox GRPQL;
    }
}

