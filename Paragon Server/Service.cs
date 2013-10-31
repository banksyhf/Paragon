using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Paragon.Core;

namespace Paragon_Server
{
    [ServiceContract]
    public class Service : IService
    {
        public void Login(string username, string password)
        {

        }
    }
}
