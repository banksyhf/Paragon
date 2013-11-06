using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Paragon.Core
{
    public class ServiceClient : IService
    {
        private readonly IService _service;

        public ServiceClient()
        {
            var factory = GenerateChannelFactory<IService>();

            _service = factory.CreateChannel();
        }

        #region " API "

        public bool Login(string username, string password)
        {
            return _service.Login(username, password);
        }

        public bool Register(string email, string username, string password)
        {
            return _service.Register(email, username, password);
        }

        public int CreateThread(string subject, string body)
        {
            return _service.CreateThread(subject, body);
        }

        #endregion " API "

        private static ChannelFactory<T> GenerateChannelFactory<T>()
        {
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None, false)
            {
                SendTimeout = TimeSpan.FromDays(24),
                ReceiveTimeout = TimeSpan.FromDays(24),
                MaxReceivedMessageSize = long.MaxValue,
                TransferMode = TransferMode.Streamed
            };
            return new ChannelFactory<T>(binding, new EndpointAddress("net.tcp://localhost:5656/Service/"));

        }
    }
}
