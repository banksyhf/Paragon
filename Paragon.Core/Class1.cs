using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paragon.Core
{
    public interface IService
    {
        void Login(string username, string password);
    }
}
