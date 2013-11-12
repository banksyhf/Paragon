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
        public FormLogin()
        {
            InitializeComponent();
            CheckServer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClient client = new ServiceClient();
            client.Register("swagger", "swag", "daddy");
            LoginResult result = client.Login("swag", "daddy");

            Console.WriteLine(result);
        }

        private async void CheckServer()
        {
            bool online = await Task.Factory.StartNew<bool>(() =>
                {
                    return new ServiceClient().IsOnline();
                });

            lblServerOnline.Text = online ? "Online." : "Offline.";
            lblServerOnline.ForeColor = online ? Color.Green : Color.Red;
        }
    }
}
