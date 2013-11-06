using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using Paragon.Core;
using Paragon_Database;

namespace Paragon_Server
{
    public class Service : IService
    {
        public bool Login(string username, string password)
        {
            return new Accessor().UserExists(username, password);
        }

        public bool Register(string email, string username, string password)
        {
            Accessor accessor = new Accessor();

            string hash = Guid.NewGuid().ToString("N");

            User user = new User
            {
                Email = email,
                Username = username,
                Password = password.Hash<SHA256Managed>(hash),
                Avatar = string.Empty,
                Hash = hash
            };

            return accessor.InsertUser(user);
        }
    }
}
