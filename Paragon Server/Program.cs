using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using Paragon.Core;
using Paragon_Database;
using System.Threading.Tasks;

namespace Paragon_Server
{
    class Program
    {
        private static Listener<IService> _listener;
        [STAThread]
        static void Main(string[] args)
        {
            Accessor.Initialize();

            _listener = new Listener<IService>(typeof(Service));

            Console.ReadLine();
        }
    }
}
