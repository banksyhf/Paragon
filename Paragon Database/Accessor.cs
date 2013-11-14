using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using System.Security.Cryptography;
using Paragon.Core;
using Paragon_Database.Database;
using Paragon_Database.Settings;

namespace Paragon_Database
{
    public static class Accessor
    {
        public static bool Initialize()
        {
            ApplicationSettings.Initialize();
            while (true)
            {
                try
                {
                    ParagonDataContext ctx = new ParagonDataContext();
                    if (!ctx.DatabaseExists())
                        ctx.CreateDatabase();

                    return true;
                }
                catch (Exception)
                {
                    using (DataConnectionDialog dialog = new DataConnectionDialog())
                    {
                        DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
                        dcs.LoadConfiguration(dialog);
                        if (DataConnectionDialog.Show(dialog) != DialogResult.OK) return false;
                        string connectionString = dialog.ConnectionString;

                        ApplicationSettings.ConnectionString = connectionString;
                    }
                }
            }
        }

        #region " Insert "

        public static RegisterResult InsertUser(User user)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            bool usernameExists = ctx.Users.Any(u => u.Username.ToLower() == user.Username.ToLower());
            bool emailExists = ctx.Users.Any(u => u.Email.ToLower() == user.Email.ToLower());

            if (usernameExists)
                return RegisterResult.UsernameExists;
            if (emailExists)
                return RegisterResult.EmailExists;

            ctx.Users.InsertOnSubmit(user);
            ctx.SubmitChanges();

            return ctx.Users.Contains(user) ? RegisterResult.Success : RegisterResult.UnknownFailure;
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
