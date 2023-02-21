namespace OOADProject.ChildForms
{
    partial class FormRequest
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbContent = new OOADProject.RJTextBox();
            this.tbReason = new OOADProject.RJTextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateMake = new OOADProject.RJDatePicker();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.BackColor = System.Drawing.SystemColors.Window;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(336, 638);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(171, 46);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // tbContent
            // 
            this.tbContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbContent.BackColor = System.Drawing.SystemColors.Window;
            this.tbContent.BorderColor = System.Drawing.Color.Black;
            this.tbContent.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbContent.BorderRadius = 4;
            this.tbContent.BorderSize = 2;
            this.tbContent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbContent.Location = new System.Drawing.Point(245, 239);
            this.tbContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbContent.PasswordChar = false;
            this.tbContent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbContent.PlaceholderText = "";
            this.tbContent.Size = new System.Drawing.Size(507, 362);
            this.tbContent.TabIndex = 21;
            this.tbContent.Texts = "";
            this.tbContent.UnderlinedStyle = false;
            // 
            // tbReason
            // 
            this.tbReason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReason.BackColor = System.Drawing.SystemColors.Window;
            this.tbReason.BorderColor = System.Drawing.Color.Black;
            this.tbReason.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbReason.BorderRadius = 4;
            this.tbReason.BorderSize = 2;
            this.tbReason.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbReason.Location = new System.Drawing.Point(245, 154);
            this.tbReason.Margin = new System.Windows.Forms.Padding(4);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbReason.PasswordChar = false;
            this.tbReason.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbReason.PlaceholderText = "";
            this.tbReason.Size = new System.Drawing.Size(507, 39);
            this.tbReason.TabIndex = 20;
            this.tbReason.Texts = "";
            this.tbReason.UnderlinedStyle = false;
            // 
            // labelContent
            // 
            this.labelContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(101, 239);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(113, 25);
            this.labelContent.TabIndex = 19;
            this.labelContent.Text = "Nội dung";
            // 
            // labelReason
            // 
            this.labelReason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReason.Location = new System.Drawing.Point(101, 163);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(73, 25);
            this.labelReason.TabIndex = 18;
            this.labelReason.Text = "Lý do";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(101, 88);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(112, 25);
            this.labelDate.TabIndex = 23;
            this.labelDate.Text = "Ngày tạo";
            // 
            // dateMake
            // 
            this.dateMake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateMake.BorderColor = System.Drawing.Color.Black;
            this.dateMake.BorderSize = 2;
            this.dateMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateMake.Location = new System.Drawing.Point(245, 78);
            this.dateMake.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateMake.Name = "dateMake";
            this.dateMake.Size = new System.Drawing.Size(507, 35);
            this.dateMake.SkinColor = System.Drawing.Color.White;
            this.dateMake.TabIndex = 24;
            this.dateMake.TextColor = System.Drawing.Color.Black;
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 730);
            this.Controls.Add(this.dateMake);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelReason);
            this.Name = "FormRequest";
            this.Text = "YÊU CẦU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private RJTextBox tbContent;
        private RJTextBox tbReason;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Label labelDate;
        private RJDatePicker dateMake;
    }
}