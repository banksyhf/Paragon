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
            if (!Accessor.Initialize())
            {
                Console.WriteLine("Failed to connect to database.\nPress any key to exit.");
                Console.ReadKey();
                return;
            }

            //Setup a Listener for IService and pass the type to handle it.
            _listener = new Listener<IService>(typeof(Service));
            //Start listening.
            _listener.Listen();

            Console.ReadLine();
        }
    }
}
