namespace OOADProject.ChildForms
{
    partial class FormChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCheck1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.labelCheck2 = new System.Windows.Forms.Label();
            this.tbConfirm = new OOADProject.RJTextBox();
            this.tbNewPass = new OOADProject.RJTextBox();
            this.tbOldPass = new OOADProject.RJTextBox();
            this.labelCheck3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelCheck3);
            this.panel1.Controls.Add(this.labelCheck2);
            this.panel1.Controls.Add(this.labelCheck1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.labelConfirm);
            this.panel1.Controls.Add(this.tbConfirm);
            this.panel1.Controls.Add(this.labelNewPass);
            this.panel1.Controls.Add(this.tbNewPass);
            this.panel1.Controls.Add(this.labelOldPass);
            this.panel1.Controls.Add(this.tbOldPass);
            this.panel1.Location = new System.Drawing.Point(135, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 354);
            this.panel1.TabIndex = 0;
            // 
            // labelCheck1
            // 
            this.labelCheck1.AutoSize = true;
            this.labelCheck1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck1.ForeColor = System.Drawing.Color.Red;
            this.labelCheck1.Location = new System.Drawing.Point(269, 236);
            this.labelCheck1.Name = "labelCheck1";
            this.labelCheck1.Size = new System.Drawing.Size(233, 20);
            this.labelCheck1.TabIndex = 9;
            this.labelCheck1.Text = "Vui lòng kiểm tra nhập lại";
            this.labelCheck1.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(189, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 46);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.Location = new System.Drawing.Point(28, 192);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(223, 25);
            this.labelConfirm.TabIndex = 7;
            this.labelConfirm.Text = "Nhập lại mật khẩu:";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.Location = new System.Drawing.Point(28, 108);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(171, 25);
            this.labelNewPass.TabIndex = 5;
            this.labelNewPass.Text = "Mật khẩu mới:";
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPass.Location = new System.Drawing.Point(28, 24);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(213, 25);
            this.labelOldPass.TabIndex = 3;
            this.labelOldPass.Text = "Mật khẩu hiện tại:";
            // 
            // labelCheck2
            // 
            this.labelCheck2.AutoSize = true;
            this.labelCheck2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck2.ForeColor = System.Drawing.Color.Red;
            this.labelCheck2.Location = new System.Drawing.Point(269, 236);
            this.labelCheck2.Name = "labelCheck2";
            this.labelCheck2.Size = new System.Drawing.Size(256, 20);
            this.labelCheck2.TabIndex = 10;
            this.labelCheck2.Text = "Mật khẩu hiện tại chưa đúng";
            this.labelCheck2.Visible = false;
            // 
            // tbConfirm
            // 
            this.tbConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.tbConfirm.BorderColor = System.Drawing.Color.Black;
            this.tbConfirm.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbConfirm.BorderRadius = 0;
            this.tbConfirm.BorderSize = 2;
            this.tbConfirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirm.Location = new System.Drawing.Point(272, 187);
            this.tbConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfirm.Multiline = false;
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbConfirm.PasswordChar = true;
            this.tbConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbConfirm.PlaceholderText = "";
            this.tbConfirm.Size = new System.Drawing.Size(283, 40);
            this.tbConfirm.TabIndex = 6;
            this.tbConfirm.Texts = "";
            this.tbConfirm.UnderlinedStyle = true;
            // 
            // tbNewPass
            // 
            this.tbNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbNewPass.BorderColor = System.Drawing.Color.Black;
            this.tbNewPass.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbNewPass.BorderRadius = 0;
            this.tbNewPass.BorderSize = 2;
            this.tbNewPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass.Location = new System.Drawing.Point(272, 103);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass.Multiline = false;
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNewPass.PasswordChar = true;
            this.tbNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNewPass.PlaceholderText = "";
            this.tbNewPass.Size = new System.Drawing.Size(283, 40);
            this.tbNewPass.TabIndex = 4;
            this.tbNewPass.Texts = "";
            this.tbNewPass.UnderlinedStyle = true;
            // 
            // tbOldPass
            // 
            this.tbOldPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbOldPass.BorderColor = System.Drawing.Color.Black;
            this.tbOldPass.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbOldPass.BorderRadius = 0;
            this.tbOldPass.BorderSize = 2;
            this.tbOldPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOldPass.Location = new System.Drawing.Point(272, 19);
            this.tbOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbOldPass.Multiline = false;
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbOldPass.PasswordChar = false;
            this.tbOldPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbOldPass.PlaceholderText = "";
            this.tbOldPass.Size = new System.Drawing.Size(283, 40);
            this.tbOldPass.TabIndex = 0;
            this.tbOldPass.Texts = "";
            this.tbOldPass.UnderlinedStyle = true;
            // 
            // labelCheck3
            // 
            this.labelCheck3.AutoSize = true;
            this.labelCheck3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck3.ForeColor = System.Drawing.Color.Red;
            this.labelCheck3.Location = new System.Drawing.Point(269, 236);
            this.labelCheck3.Name = "labelCheck3";
            this.labelCheck3.Size = new System.Drawing.Size(188, 20);
            this.labelCheck3.TabIndex = 11;
            this.labelCheck3.Text = "Vui lòng điền đầy đủ";
            this.labelCheck3.Visible = false;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 730);
            this.Controls.Add(this.panel1);
            this.Name = "FormChangePassword";
            this.Text = "ĐỔI MẬT KHẨU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJTextBox tbOldPass;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelConfirm;
        private RJTextBox tbConfirm;
        private System.Windows.Forms.Label labelNewPass;
        private RJTextBox tbNewPass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelCheck1;
        private System.Windows.Forms.Label labelCheck2;
        private System.Windows.Forms.Label labelCheck3;
    }
}