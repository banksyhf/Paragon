using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Paragon.Core;

namespace Paragon
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            bool s = new ServiceClient().Register("swegger", "swag", "daddy");

            Console.WriteLine(s);
        }
    }
}
