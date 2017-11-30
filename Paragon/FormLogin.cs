using Paragon.Core;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paragon
{
    public partial class FormLogin : Form
    {
        private readonly ServiceClient _service;
        public FormLogin()
        {
            InitializeComponent();

            txtUsername.Select();

            _service = new ServiceClient();
            CheckServer();
        }

        private async void CheckServer()
        {
            bool online = await Task.Factory.StartNew(() => _service.IsOnline());

            lblServerOnline.Text = online ? "Online." : "Offline.";
            lblServerOnline.ForeColor = online ? Color.Green : Color.Red;
            btnLogin.Enabled = true;
            btnToRegister.Enabled = true;
            btnRegister.Enabled = true;
            btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _service.Login(txtUsername.Text, txtPassword.Text);
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            hiddenTab1.SelectedIndex = 1;
            txtRegisterUsername.Select();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterResult r = _service.Register(txtRegisterEmail.Text, txtRegisterUsername.Text, txtRegisterPassword.Text);

            HandleRegisterResult(r);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            hiddenTab1.SelectedIndex = 0;
        }

        private void HandleRegisterResult(RegisterResult result)
        {
            switch (result)
            {
                case RegisterResult.Success:
                    hiddenTab1.SelectedIndex = 0;
                    SetRegisterResultLabel("", false);
                    break;
                case RegisterResult.UsernameExists:
                    SetRegisterResultLabel("Failed to register. Username already exists.", true);
                    break;
                case RegisterResult.EmailExists:
                    SetRegisterResultLabel("Failed to register. Email already exists.", true);
                    break;
                case RegisterResult.UsernameTooLong:
                    SetRegisterResultLabel("Failed to register. Username too long.", true);
                    break;
                case RegisterResult.InvalidEmail:
                    SetRegisterResultLabel("Failed to register. Not a valid email.", true);
                    break;
            }
        }

        private void SetRegisterResultLabel(string text, bool registerFailed)
        {

            if (registerFailed)
                lblRegisterResult.Show();
            else
                lblRegisterResult.Hide();

            lblRegisterResult.Text = text;

            Point p = new Point();
            p.X = tabRegister.Width / 2 - lblRegisterResult.Width / 2;
            p.Y = lblRegisterResult.Location.Y;

            lblRegisterResult.Location = p;

        }
    }
}
