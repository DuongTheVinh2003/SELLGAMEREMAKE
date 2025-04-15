using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SELLGAMEREAMKE
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndnhap_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;
            if (username == "admin" && password == "admin")
            {
                TrangChu trangChu = new TrangChu();
                this.Hide();
                trangChu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản sai! Vui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
