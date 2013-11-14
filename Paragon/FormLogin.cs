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
            lblfocus.Select();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _service.Register(txtRegisterEmail.Text, txtRegisterUsername.Text, txtRegisterPassword.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            hiddenTab1.SelectedIndex = 0;
        }
    }
}
