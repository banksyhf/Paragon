using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Paragon_Database
{
    public static class Accessor
    {
        public static void Initialize()
        {
            ParagonDataContext ctx = new ParagonDataContext();
            if (!ctx.DatabaseExists())
                ctx.CreateDatabase();
        }

        #region " Insert "

        public static bool InsertUser(User user)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            bool usernameExists = ctx.Users.Any(u => u.Username.ToLower() == user.Username.ToLower());
            bool emailExists = ctx.Users.Any(u => u.Email.ToLower() == user.Email.ToLower());

            if (usernameExists || emailExists)
            {
                return false; // TODO: Return specific error?
            }

            ctx.Users.InsertOnSubmit(user);
            ctx.SubmitChanges();

            return ctx.Users.Contains(user);
        }

        public static bool InsertThread(int forumId, string subject, string body)
        {
            //TODO: Insert thread into database.

            return true;
        }

        #endregion

        #region " User Functions "

        public static bool UserExists(string username, string password)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            User user = ctx.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());

            if (user != null)
                return user.Password == password.Hash<SHA256Managed>(user.Hash);

            return false; //User doesn't exist, return false.
        }

        public static User FindUserFromUsername(string username)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            return ctx.Users.FirstOrDefault(x => x.Username == username.ToLower());
        }

        #endregion
    }
}
