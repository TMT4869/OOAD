namespace OOADProject.ChildForms
{
    partial class FormListEmployee
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
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new OOADProject.RJTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchEmployee.FlatAppearance.BorderSize = 2;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnSearchEmployee.Location = new System.Drawing.Point(623, 6);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(133, 40);
            this.btnSearchEmployee.TabIndex = 18;
            this.btnSearchEmployee.Text = "Tìm kiếm";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.btnSearchEmployee);
            this.panelSearch.Controls.Add(this.tbSearch);
            this.panelSearch.Location = new System.Drawing.Point(47, 35);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(759, 55);
            this.panelSearch.TabIndex = 3;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbSearch.BorderRadius = 0;
            this.tbSearch.BorderSize = 2;
            this.tbSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearch.Location = new System.Drawing.Point(4, 6);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbSearch.PasswordChar = false;
            this.tbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSearch.PlaceholderText = "Tìm kiếm";
            this.tbSearch.Size = new System.Drawing.Size(599, 40);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Texts = "";
            this.tbSearch.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSNV,
            this.tenNhanVien,
            this.taiKhoan,
            this.chucVu,
            this.tenPhongBan,
            this.email,
            this.ngaySinh,
            this.soDienThoai});
            this.dataGridView1.Location = new System.Drawing.Point(47, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 578);
            this.dataGridView1.TabIndex = 5;
            // 
            // MSNV
            // 
            this.MSNV.DataPropertyName = "MSNV";
            this.MSNV.HeaderText = "MSNV";
            this.MSNV.MinimumWidth = 6;
            this.MSNV.Name = "MSNV";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Họ tên";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // taiKhoan
            // 
            this.taiKhoan.DataPropertyName = "taiKhoan";
            this.taiKhoan.HeaderText = "Tài khoản";
            this.taiKhoan.MinimumWidth = 6;
            this.taiKhoan.Name = "taiKhoan";
            // 
            // chucVu
            // 
            this.chucVu.DataPropertyName = "chucVu";
            this.chucVu.HeaderText = "Chức vụ";
            this.chucVu.MinimumWidth = 6;
            this.chucVu.Name = "chucVu";
            // 
            // tenPhongBan
            // 
            this.tenPhongBan.DataPropertyName = "tenPhongBan";
            this.tenPhongBan.HeaderText = "Phòng ban";
            this.tenPhongBan.MinimumWidth = 6;
            this.tenPhongBan.Name = "tenPhongBan";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "SĐT";
            this.soDienThoai.MinimumWidth = 6;
            this.soDienThoai.Name = "soDienThoai";
            // 
            // FormListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 730);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelSearch);
            this.Name = "FormListEmployee";
            this.Text = "DANH SÁCH NHÂN VIÊN";
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJTextBox tbSearch;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
    }
}