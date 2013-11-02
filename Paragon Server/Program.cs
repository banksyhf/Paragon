using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paragon.Core;

namespace Paragon_Server
{
    class Program
    {
        private static Listener<IService> _listener;
        static void Main(string[] args)
        {
            _listener = new Listener<IService>(typeof(Service));

            Console.ReadLine();
        }

    }
}
