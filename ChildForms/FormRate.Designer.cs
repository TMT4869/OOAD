namespace OOADProject.ChildForms
{
    partial class FormRate
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbBD = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbDayleave = new System.Windows.Forms.TextBox();
            this.labelDayleave = new System.Windows.Forms.Label();
            this.tbOvertime = new System.Windows.Forms.TextBox();
            this.labelOvertime = new System.Windows.Forms.Label();
            this.labelComplete = new System.Windows.Forms.Label();
            this.cbComplete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(176, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 46);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // labelDepartment
            // 
            this.labelDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(276, 257);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(131, 25);
            this.labelDepartment.TabIndex = 48;
            this.labelDepartment.Text = "Phòng ban";
            // 
            // tbPosition
            // 
            this.tbPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPosition.Enabled = false;
            this.tbPosition.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(52, 285);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(208, 28);
            this.tbPosition.TabIndex = 47;
            // 
            // tbBD
            // 
            this.tbBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBD.Enabled = false;
            this.tbBD.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBD.Location = new System.Drawing.Point(608, 171);
            this.tbBD.Name = "tbBD";
            this.tbBD.Size = new System.Drawing.Size(199, 28);
            this.tbBD.TabIndex = 46;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(281, 171);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(274, 28);
            this.tbName.TabIndex = 45;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(50, 171);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(210, 28);
            this.tbID.TabIndex = 44;
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(47, 250);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(100, 25);
            this.labelPosition.TabIndex = 42;
            this.labelPosition.Text = "Chức vụ";
            // 
            // labelBD
            // 
            this.labelBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBD.Location = new System.Drawing.Point(603, 135);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(123, 25);
            this.labelBD.TabIndex = 41;
            this.labelBD.Text = "Ngày sinh";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(276, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(169, 25);
            this.labelName.TabIndex = 40;
            this.labelName.Text = "Tên nhân viên";
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(45, 135);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(77, 25);
            this.labelID.TabIndex = 39;
            this.labelID.Text = "MSNV";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDepartment.Enabled = false;
            this.tbDepartment.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartment.Location = new System.Drawing.Point(281, 285);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(526, 28);
            this.tbDepartment.TabIndex = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(457, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 46);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // tbDayleave
            // 
            this.tbDayleave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDayleave.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayleave.Location = new System.Drawing.Point(50, 411);
            this.tbDayleave.Name = "tbDayleave";
            this.tbDayleave.Size = new System.Drawing.Size(210, 28);
            this.tbDayleave.TabIndex = 53;
            // 
            // labelDayleave
            // 
            this.labelDayleave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDayleave.AutoSize = true;
            this.labelDayleave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayleave.Location = new System.Drawing.Point(45, 376);
            this.labelDayleave.Name = "labelDayleave";
            this.labelDayleave.Size = new System.Drawing.Size(157, 25);
            this.labelDayleave.TabIndex = 52;
            this.labelDayleave.Text = "Số ngày nghỉ";
            // 
            // tbOvertime
            // 
            this.tbOvertime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOvertime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOvertime.Location = new System.Drawing.Point(52, 529);
            this.tbOvertime.Name = "tbOvertime";
            this.tbOvertime.Size = new System.Drawing.Size(208, 28);
            this.tbOvertime.TabIndex = 55;
            // 
            // labelOvertime
            // 
            this.labelOvertime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOvertime.AutoSize = true;
            this.labelOvertime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOvertime.Location = new System.Drawing.Point(47, 494);
            this.labelOvertime.Name = "labelOvertime";
            this.labelOvertime.Size = new System.Drawing.Size(213, 25);
            this.labelOvertime.TabIndex = 54;
            this.labelOvertime.Text = "Số ngày làm thêm";
            // 
            // labelComplete
            // 
            this.labelComplete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelComplete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplete.Location = new System.Drawing.Point(276, 376);
            this.labelComplete.Name = "labelComplete";
            this.labelComplete.Size = new System.Drawing.Size(431, 33);
            this.labelComplete.TabIndex = 57;
            this.labelComplete.Text = "Mức độ hoàn thành công việc";
            // 
            // cbComplete
            // 
            this.cbComplete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbComplete.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComplete.FormattingEnabled = true;
            this.cbComplete.Location = new System.Drawing.Point(279, 411);
            this.cbComplete.Name = "cbComplete";
            this.cbComplete.Size = new System.Drawing.Size(528, 28);
            this.cbComplete.TabIndex = 56;
            // 
            // FormRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 730);
            this.Controls.Add(this.labelComplete);
            this.Controls.Add(this.cbComplete);
            this.Controls.Add(this.tbOvertime);
            this.Controls.Add(this.labelOvertime);
            this.Controls.Add(this.tbDayleave);
            this.Controls.Add(this.labelDayleave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbBD);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "FormRate";
            this.Text = "ĐÁNH GIÁ NHÂN VIÊN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbBD;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbDayleave;
        private System.Windows.Forms.Label labelDayleave;
        private System.Windows.Forms.TextBox tbOvertime;
        private System.Windows.Forms.Label labelOvertime;
        private System.Windows.Forms.Label labelComplete;
        private System.Windows.Forms.ComboBox cbComplete;
    }
}