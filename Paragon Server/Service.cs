using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            return true;
        }

        public bool Register(string email, string username, string password)
        {
            Accessor accessor = new Accessor();

            User user = new User()
            {
                Email = email,
                Username = username,
                Password = password,
                Avatar = string.Empty,
                Hash = ""
            };

            accessor.InsertUser(user);
            

            return true;
        }
    }
}
