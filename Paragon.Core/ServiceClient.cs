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

        public LoginResult Login(string username, string password)
        {
            try { return _service.Login(username, password); }
            catch { return LoginResult.UnknownFailure; }
        }

        public RegisterResult Register(string email, string username, string password)
        {
            try { return _service.Register(email, username, password); }
            catch { return RegisterResult.UnknownFailure; }
        }

        public int CreateThread(int forumId, string subject, string body)
        {
            try {return _service.CreateThread(forumId, subject, body); }
            catch { return -1; }
        }

        public bool IsOnline()
        {
            try { return _service.IsOnline(); }
            catch { return false; }
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
