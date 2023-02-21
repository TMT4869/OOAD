namespace OOADProject
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pwTextBox = new OOADProject.RJTextBox();
            this.unTextBox = new OOADProject.RJTextBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.HotPink;
            this.btnLogin.Location = new System.Drawing.Point(186, 411);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 41);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panelLogin.Controls.Add(this.btnExit);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.pictureBoxHome);
            this.panelLogin.Controls.Add(this.pwTextBox);
            this.panelLogin.Controls.Add(this.unTextBox);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(677, 429);
            this.panelLogin.TabIndex = 2;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.HotPink;
            this.btnExit.Location = new System.Drawing.Point(366, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::OOADProject.Properties.Resources.Ephoto360_com_163e31e5f8d188;
            this.pictureBoxHome.Location = new System.Drawing.Point(245, 22);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(203, 203);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 4;
            this.pictureBoxHome.TabStop = false;
            // 
            // pwTextBox
            // 
            this.pwTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pwTextBox.BorderColor = System.Drawing.Color.HotPink;
            this.pwTextBox.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.pwTextBox.BorderRadius = 10;
            this.pwTextBox.BorderSize = 2;
            this.pwTextBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.pwTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwTextBox.Location = new System.Drawing.Point(212, 344);
            this.pwTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pwTextBox.Multiline = false;
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pwTextBox.PasswordChar = true;
            this.pwTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pwTextBox.PlaceholderText = "password";
            this.pwTextBox.Size = new System.Drawing.Size(258, 35);
            this.pwTextBox.TabIndex = 3;
            this.pwTextBox.Texts = "";
            this.pwTextBox.UnderlinedStyle = false;
            // 
            // unTextBox
            // 
            this.unTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.unTextBox.BorderColor = System.Drawing.Color.HotPink;
            this.unTextBox.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.unTextBox.BorderRadius = 10;
            this.unTextBox.BorderSize = 2;
            this.unTextBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.unTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unTextBox.Location = new System.Drawing.Point(212, 277);
            this.unTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unTextBox.Multiline = false;
            this.unTextBox.Name = "unTextBox";
            this.unTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.unTextBox.PasswordChar = false;
            this.unTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.unTextBox.PlaceholderText = "username";
            this.unTextBox.Size = new System.Drawing.Size(258, 35);
            this.unTextBox.TabIndex = 2;
            this.unTextBox.Texts = "";
            this.unTextBox.UnderlinedStyle = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 429);
            this.Controls.Add(this.panelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJTextBox unTextBox;
        private RJTextBox pwTextBox;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnExit;
    }
}

