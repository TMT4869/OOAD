namespace OOADProject.ChildForms
{
    partial class FormERequest
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
            this.dataRequest = new System.Windows.Forms.DataGridView();
            this.IDForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRequest
            // 
            this.dataRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDForm,
            this.MSNV,
            this.tenNhanVien,
            this.ngayTao,
            this.trangThai});
            this.dataRequest.Location = new System.Drawing.Point(40, 70);
            this.dataRequest.Name = "dataRequest";
            this.dataRequest.RowHeadersWidth = 51;
            this.dataRequest.RowTemplate.Height = 24;
            this.dataRequest.Size = new System.Drawing.Size(759, 624);
            this.dataRequest.TabIndex = 0;
            // 
            // IDForm
            // 
            this.IDForm.HeaderText = "Mã yêu cầu";
            this.IDForm.MinimumWidth = 6;
            this.IDForm.Name = "IDForm";
            // 
            // MSNV
            // 
            this.MSNV.HeaderText = "MSNV";
            this.MSNV.MinimumWidth = 6;
            this.MSNV.Name = "MSNV";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.HeaderText = "Họ tên";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // ngayTao
            // 
            this.ngayTao.HeaderText = "Ngày tạo";
            this.ngayTao.MinimumWidth = 6;
            this.ngayTao.Name = "ngayTao";
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // FormERequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 730);
            this.Controls.Add(this.dataRequest);
            this.Name = "FormERequest";
            this.Text = "YÊU CẦU NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.dataRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}