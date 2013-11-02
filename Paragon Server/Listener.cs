using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Paragon.Core;

namespace Paragon_Server
{
    internal class Listener<T>
    {
        private ServiceHost _host;

        public Listener(Type type)
        {
            //TODO: Do some initialization?

            Listen(type);
        }

        private void Listen(Type type)
        {

            _host = new ServiceHost(type, new Uri("net.tcp://tempuri.org:5656/Service/"));
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None, false)
            {
                ReceiveTimeout = TimeSpan.MaxValue,
                SendTimeout = TimeSpan.MaxValue,
                TransferMode = TransferMode.Streamed,
                MaxReceivedMessageSize = long.MaxValue,
            };

            _host.AddServiceEndpoint(typeof(T), binding, string.Empty);
            _host.Open();
        }

    }
}
