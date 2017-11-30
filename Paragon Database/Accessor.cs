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
        private static UserAccessor _userAccessor;
        private static ThreadAccessor _threadAccessor;

        public static bool Initialize()
        {
            ApplicationSettings.Initialize();
            while (true)
            {
                //TODO: Get rid of this try. Not sure what I was doing originally.
                //This is completely broken and just (predictably) fails if it can't connect to the database or what have you.
                //Kinda makes it hard for someone to set this up if they don't know what I was doing, which if I'm being honest, I didn't.
                try
                {
                    ParagonDataContext ctx = new ParagonDataContext();
                    //TODO: Pretty sure this fails everytime if the database doesn't exist so go me, this is very helpful. Idiot.
                    if (!ctx.DatabaseExists())
                        ctx.CreateDatabase();

                    _userAccessor = new UserAccessor();


                    return true;
                }
                catch (Exception)
                {
                    //So I just spent like 3 hours trying to get a SQL Server running and this never popped up once. I have no idea what I was doing.
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

        public static RegisterResult InsertUser(User user)
        {
            return _userAccessor.InsertUser(user);
        }

        public static LoginResult UserExists(string username, string password)
        {
            return _userAccessor.UserExists(username, password);
        }

        public static User FindUserFromUsername(string username)
        {
            return _userAccessor.FindUserFromUsername(username);
        }

        //TODO: Create Thread or ThreadCreation class or something similar instead of these parameters.
        public static int InsertThread(int forumId, string subject, string body)
        {
            //TODO: Insert thread into database.
            return _threadAccessor.InsertThread(forumId, subject, body);
        }
    }
}
