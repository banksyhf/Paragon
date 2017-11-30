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
        private readonly Type _type;

        public Listener(Type type)
        {
            _type = type;
        }

        public void Listen()
        {
            Listen(_type);
        }

        internal void Stop()
        {
            _host.Close();

        }

        private void Listen(Type type)
        {

            _host = new ServiceHost(type, new Uri("net.tcp://127.0.0.1:5656/Service/"));
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None, false)
            {
                ReceiveTimeout = TimeSpan.MaxValue,
                SendTimeout = TimeSpan.MaxValue,
                TransferMode = TransferMode.Streamed,
                MaxReceivedMessageSize = long.MaxValue, //TODO: Change to appropriate max message size
            };

            _host.AddServiceEndpoint(typeof(T), binding, string.Empty);
            _host.Open();
        }

    }
}
