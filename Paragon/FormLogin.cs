using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Paragon.Core;
using System.Threading.Tasks;

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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _service.Login(txtUsername.Text, txtPassword.Text);
        }
    }
}
