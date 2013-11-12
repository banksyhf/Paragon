﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Paragon.Core;

namespace Paragon_Database
{
    public static class Accessor
    {
        public static void Initialize()
        {
            try
            {
                ParagonDataContext ctx = new ParagonDataContext();
                if (!ctx.DatabaseExists())
                    ctx.CreateDatabase();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        #region " Insert "

        public static bool InsertUser(User user)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            bool usernameExists = ctx.Users.Any(u => String.Equals(u.Username, user.Username, StringComparison.CurrentCultureIgnoreCase));
            bool emailExists = ctx.Users.Any(u => String.Equals(u.Email, user.Email, StringComparison.CurrentCultureIgnoreCase));

            if (usernameExists || emailExists)
            {
                return false; // TODO: Return specific error?
            }

            ctx.Users.InsertOnSubmit(user);
            ctx.SubmitChanges();

            return ctx.Users.Contains(user);
        }

        public static int InsertThread(int forumId, string subject, string body)
        {
            //TODO: Insert thread into database.

            return 0;
        }

        #endregion

        #region " User Functions "

        public static LoginResult UserExists(string username, string password)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            username = username.ToLower();

            User user = ctx.Users.FirstOrDefault(x =>
                x.Username.ToLower() == username
                || x.Email.ToLower() == username);

            if (user == null)
                return LoginResult.WrongUsername; //User doesn't exist, user must have entered wrong username/email.


            if (user.Password == password.Hash<SHA256Managed>(user.Hash))
                return LoginResult.Success; //User password == given password :D

            //User password is not == to given password, return WrongPassword.
            return LoginResult.WrongPassword;
        }

        public static User FindUserFromUsername(string username)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            return ctx.Users.FirstOrDefault(x => x.Username == username.ToLower());
        }

        #endregion
    }
}
