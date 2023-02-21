namespace OOADProject
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnCalSalary = new System.Windows.Forms.Button();
            this.panelEmployeeSubmenu = new System.Windows.Forms.Panel();
            this.btnRate = new System.Windows.Forms.Button();
            this.btnERequest = new System.Windows.Forms.Button();
            this.btnAddRemoveEmployee = new System.Windows.Forms.Button();
            this.btnListEmployee = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelEmployeeSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCreateAcc);
            this.panelMenu.Controls.Add(this.btnCalSalary);
            this.panelMenu.Controls.Add(this.panelEmployeeSubmenu);
            this.panelMenu.Controls.Add(this.btnEmployee);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnChangePassword);
            this.panelMenu.Controls.Add(this.btnRequest);
            this.panelMenu.Controls.Add(this.btnSalary);
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 766);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCreateAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreateAcc.Location = new System.Drawing.Point(0, 561);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreateAcc.Size = new System.Drawing.Size(230, 45);
            this.btnCreateAcc.TabIndex = 14;
            this.btnCreateAcc.Text = "Tạo tài khoản";
            this.btnCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnCalSalary
            // 
            this.btnCalSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalSalary.FlatAppearance.BorderSize = 0;
            this.btnCalSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalSalary.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCalSalary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalSalary.Location = new System.Drawing.Point(0, 516);
            this.btnCalSalary.Name = "btnCalSalary";
            this.btnCalSalary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalSalary.Size = new System.Drawing.Size(230, 45);
            this.btnCalSalary.TabIndex = 13;
            this.btnCalSalary.Text = "Tính lương";
            this.btnCalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalSalary.UseVisualStyleBackColor = true;
            this.btnCalSalary.Click += new System.EventHandler(this.btnCalSalary_Click);
            // 
            // panelEmployeeSubmenu
            // 
            this.panelEmployeeSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panelEmployeeSubmenu.Controls.Add(this.btnRate);
            this.panelEmployeeSubmenu.Controls.Add(this.btnERequest);
            this.panelEmployeeSubmenu.Controls.Add(this.btnAddRemoveEmployee);
            this.panelEmployeeSubmenu.Controls.Add(this.btnListEmployee);
            this.panelEmployeeSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeeSubmenu.Location = new System.Drawing.Point(0, 336);
            this.panelEmployeeSubmenu.Name = "panelEmployeeSubmenu";
            this.panelEmployeeSubmenu.Size = new System.Drawing.Size(230, 180);
            this.panelEmployeeSubmenu.TabIndex = 12;
            // 
            // btnRate
            // 
            this.btnRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRate.FlatAppearance.BorderSize = 0;
            this.btnRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnRate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRate.Location = new System.Drawing.Point(0, 135);
            this.btnRate.Name = "btnRate";
            this.btnRate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRate.Size = new System.Drawing.Size(230, 45);
            this.btnRate.TabIndex = 9;
            this.btnRate.Text = "Đánh giá";
            this.btnRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRate.UseVisualStyleBackColor = false;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // btnERequest
            // 
            this.btnERequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnERequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnERequest.FlatAppearance.BorderSize = 0;
            this.btnERequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnERequest.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnERequest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnERequest.Location = new System.Drawing.Point(0, 90);
            this.btnERequest.Name = "btnERequest";
            this.btnERequest.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnERequest.Size = new System.Drawing.Size(230, 45);
            this.btnERequest.TabIndex = 8;
            this.btnERequest.Text = "Yêu cầu nhân viên";
            this.btnERequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnERequest.UseVisualStyleBackColor = false;
            this.btnERequest.Click += new System.EventHandler(this.btnERequest_Click);
            // 
            // btnAddRemoveEmployee
            // 
            this.btnAddRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnAddRemoveEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRemoveEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRemoveEmployee.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnAddRemoveEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddRemoveEmployee.Location = new System.Drawing.Point(0, 45);
            this.btnAddRemoveEmployee.Name = "btnAddRemoveEmployee";
            this.btnAddRemoveEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddRemoveEmployee.Size = new System.Drawing.Size(230, 45);
            this.btnAddRemoveEmployee.TabIndex = 6;
            this.btnAddRemoveEmployee.Text = "Thêm/Xóa";
            this.btnAddRemoveEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnAddRemoveEmployee.Click += new System.EventHandler(this.btnAddRemoveEmployee_Click);
            // 
            // btnListEmployee
            // 
            this.btnListEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnListEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListEmployee.FlatAppearance.BorderSize = 0;
            this.btnListEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListEmployee.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnListEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnListEmployee.Name = "btnListEmployee";
            this.btnListEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListEmployee.Size = new System.Drawing.Size(230, 45);
            this.btnListEmployee.TabIndex = 5;
            this.btnListEmployee.Text = "Danh sách";
            this.btnListEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListEmployee.UseVisualStyleBackColor = false;
            this.btnListEmployee.Click += new System.EventHandler(this.btnListEmployee_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.Location = new System.Drawing.Point(0, 291);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(230, 45);
            this.btnEmployee.TabIndex = 9;
            this.btnEmployee.Text = "Quản lý nhân viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Location = new System.Drawing.Point(0, 721);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(230, 45);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 246);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(230, 45);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnRequest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRequest.Location = new System.Drawing.Point(0, 201);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRequest.Size = new System.Drawing.Size(230, 45);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Yêu cầu";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnSalary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalary.Location = new System.Drawing.Point(0, 156);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(230, 45);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "Phiếu lương";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 111);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(230, 45);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Thông tin cá nhân";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 111);
            this.panelLogo.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(827, 82);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(309, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANG CHỦ";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Controls.Add(this.pictureBoxHome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 82);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(827, 684);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHome.Image = global::OOADProject.Properties.Resources.Ephoto360_com_163e31e5f8d188;
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(827, 684);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::OOADProject.Properties.Resources._4103051;
            this.btnMinimize.Location = new System.Drawing.Point(707, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(60, 82);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::OOADProject.Properties.Resources._4103062;
            this.btnMaximize.Location = new System.Drawing.Point(767, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(60, 82);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::OOADProject.Properties.Resources.close;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(60, 82);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::OOADProject.Properties.Resources._3280979;
            this.pictureBoxLogo.Location = new System.Drawing.Point(65, 8);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 766);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.Resize += new System.EventHandler(this.FormAdmin_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelEmployeeSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panelEmployeeSubmenu;
        private System.Windows.Forms.Button btnAddRemoveEmployee;
        private System.Windows.Forms.Button btnListEmployee;
        private System.Windows.Forms.Button btnCalSalary;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnERequest;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}