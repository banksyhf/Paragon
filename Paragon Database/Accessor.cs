using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paragon_Database
{
    public class Accessor
    {
        public Accessor()
        {
            ParagonDataContext ctx = new ParagonDataContext();

            if (!ctx.DatabaseExists())
                ctx.CreateDatabase();
        }

        public bool InsertUser(User user)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            ctx.Users.InsertOnSubmit(user);
            ctx.SubmitChanges();

            return ctx.Users.Contains(user);
        }
    }
}
