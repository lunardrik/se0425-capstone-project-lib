using System;
using System.Windows.Forms;

namespace LIB
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private Feature _feature = new Feature();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            if (_feature.Login(txtUsername.Text, txtPassword.Text))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
