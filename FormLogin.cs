using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADProject
{
    public partial class FormLogin : Form
    {
        string query = "", connectionString = @"Data Source = LAPHAO\TIEUMANTHAU; Initial Catalog = QLNS; User ID = sa; Password = 15122001";

        public FormLogin()
        {
            InitializeComponent();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

            private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.HotPink;
            btnLogin.ForeColor = Color.FromArgb(0, 9, 43);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(0, 9, 43);
            btnLogin.ForeColor = Color.HotPink;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(0, 9, 43);
            btnExit.ForeColor = Color.HotPink;
        }

        
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.HotPink;
            btnExit.ForeColor = Color.FromArgb(0, 9, 43);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (unTextBox.Texts != string.Empty || pwTextBox.Texts != string.Empty)
            {
                query = "SELECT * FROM taiKhoan where taiKhoan='" + unTextBox.Texts + "' and matKhau='" + pwTextBox.Texts + "'";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ClassAccount.username = unTextBox.Texts;
                    switch (dr[2].ToString())
                    {
                        case "Admin":
                            dr.Close();
                            FormAdmin fAdmin = new FormAdmin();
                            this.Hide();
                            fAdmin.Show();
                            connection.Close();
                            break;
                        case "Quan ly":
                            dr.Close();
                            FormManager fManager = new FormManager();
                            this.Hide();
                            fManager.Show();
                            connection.Close();
                            break;
                        case "Nhan vien":
                            dr.Close();
                            FormEmployee fEmployee = new FormEmployee();
                            this.Hide();
                            fEmployee.Show();
                            connection.Close();
                            break;
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Không có tài khoản nào phù hợp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
