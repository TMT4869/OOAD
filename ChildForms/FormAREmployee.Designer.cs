namespace OOADProject.ChildForms
{
    partial class FormAREmployee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.tbBD = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.labelBD = new System.Windows.Forms.Label();
            this.tabRemove = new System.Windows.Forms.TabPage();
            this.panelRemove = new System.Windows.Forms.Panel();
            this.panelList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.tabRemove.SuspendLayout();
            this.panelRemove.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabRemove);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 730);
            this.tabControl1.TabIndex = 14;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.panelAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(841, 697);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Thêm nhân viên";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelAdd.Controls.Add(this.btnSearch);
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.labelDepartment);
            this.panelAdd.Controls.Add(this.tbPosition);
            this.panelAdd.Controls.Add(this.tbBD);
            this.panelAdd.Controls.Add(this.tbName);
            this.panelAdd.Controls.Add(this.tbID);
            this.panelAdd.Controls.Add(this.cbDepartment);
            this.panelAdd.Controls.Add(this.labelPosition);
            this.panelAdd.Controls.Add(this.labelBD);
            this.panelAdd.Controls.Add(this.labelName);
            this.panelAdd.Controls.Add(this.labelID);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(3, 3);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(835, 691);
            this.panelAdd.TabIndex = 27;
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
            this.btnSearch.Location = new System.Drawing.Point(182, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 46);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(475, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 46);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // labelDepartment
            // 
            this.labelDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(283, 359);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(131, 25);
            this.labelDepartment.TabIndex = 36;
            this.labelDepartment.Text = "Phòng ban";
            // 
            // tbBD
            // 
            this.tbBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBD.Enabled = false;
            this.tbBD.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBD.Location = new System.Drawing.Point(587, 242);
            this.tbBD.Name = "tbBD";
            this.tbBD.Size = new System.Drawing.Size(221, 28);
            this.tbBD.TabIndex = 34;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDepartment.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(288, 394);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(520, 28);
            this.cbDepartment.TabIndex = 31;
            // 
            // labelBD
            // 
            this.labelBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBD.Location = new System.Drawing.Point(582, 206);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(123, 25);
            this.labelBD.TabIndex = 29;
            this.labelBD.Text = "Ngày sinh";
            // 
            // tabRemove
            // 
            this.tabRemove.Controls.Add(this.panelRemove);
            this.tabRemove.Location = new System.Drawing.Point(4, 29);
            this.tabRemove.Name = "tabRemove";
            this.tabRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemove.Size = new System.Drawing.Size(841, 697);
            this.tabRemove.TabIndex = 1;
            this.tabRemove.Text = "Xóa nhân viên";
            this.tabRemove.UseVisualStyleBackColor = true;
            // 
            // panelRemove
            // 
            this.panelRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelRemove.Controls.Add(this.panelList);
            this.panelRemove.Controls.Add(this.btnRemove);
            this.panelRemove.Controls.Add(this.label3);
            this.panelRemove.Controls.Add(this.comboBox2);
            this.panelRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRemove.Location = new System.Drawing.Point(3, 3);
            this.panelRemove.Name = "panelRemove";
            this.panelRemove.Size = new System.Drawing.Size(835, 691);
            this.panelRemove.TabIndex = 0;
            // 
            // panelList
            // 
            this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelList.AutoSize = true;
            this.panelList.Controls.Add(this.dataGridView1);
            this.panelList.Location = new System.Drawing.Point(28, 154);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(778, 483);
            this.panelList.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 483);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(635, 63);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(171, 46);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phòng ban";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(580, 28);
            this.comboBox2.TabIndex = 29;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(46, 206);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(77, 25);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "MSNV";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(283, 206);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(169, 25);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "Tên nhân viên";
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(46, 359);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(100, 25);
            this.labelPosition.TabIndex = 30;
            this.labelPosition.Text = "Chức vụ";
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(51, 242);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(213, 28);
            this.tbID.TabIndex = 32;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(288, 242);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(274, 28);
            this.tbName.TabIndex = 33;
            // 
            // tbPosition
            // 
            this.tbPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPosition.Enabled = false;
            this.tbPosition.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(51, 394);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(213, 28);
            this.tbPosition.TabIndex = 35;
            // 
            // FormAREmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 730);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAREmployee";
            this.Text = "THÊM/XÓA NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FormAREmployee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.tabRemove.ResumeLayout(false);
            this.panelRemove.ResumeLayout(false);
            this.panelRemove.PerformLayout();
            this.panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabRemove;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox tbBD;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Panel panelRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
    }
}