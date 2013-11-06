using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paragon.Core;
using Paragon_Database;

namespace Paragon_Server
{
    class Program
    {
        private static Listener<IService> _listener;
        static void Main(string[] args)
        {
            Accessor.Initialize();

            _listener = new Listener<IService>(typeof(Service));

            Console.ReadLine();
        }

    }
}
