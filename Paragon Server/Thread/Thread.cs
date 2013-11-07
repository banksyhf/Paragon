using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paragon_Database;

namespace Paragon_Server.Thread
{
    internal class Thread
    {
        public static int Create(int forumId, string subject, string body)
        {
            int insert = Accessor.InsertThread(forumId, subject, body);

            //TODO: Do... more?

            return insert;
        }
    }
}
