using Paragon.Core;
using Paragon_Database.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Paragon_Database
{
    internal class UserAccessor
    {
        ParagonDataContext _context;

        public UserAccessor()
        {
            _context = new ParagonDataContext();
        }

        public RegisterResult InsertUser(User user)
        {
            ParagonDataContext ctx = new ParagonDataContext();


            if (UsernameExists(user.Username))
                return RegisterResult.UsernameExists;
            if (EmailExists(user.Email))
                return RegisterResult.EmailExists;
            if (UsernameTooLong(user.Username))
                return RegisterResult.UsernameTooLong;
            if (!IsInvalidEmail(user.Email))
                return RegisterResult.InvalidEmail;

            ctx.Users.InsertOnSubmit(user);
            ctx.SubmitChanges();

            return ctx.Users.Contains(user) ? RegisterResult.Success : RegisterResult.UnknownFailure;
        }

        public LoginResult UserExists(string username, string password)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            username = username.ToLower();

            User user = ctx.Users.FirstOrDefault(x =>
                UsernameExists(username)
                || EmailExists(username));

            if (user == null)
                return LoginResult.WrongUsername; //User doesn't exist, user must have entered wrong username/email.


            if (user.Password == password.Hash<SHA256Managed>(user.Hash))
                return LoginResult.Success; //User password == given password :D

            //User password is not == to given password, return WrongPassword.
            return LoginResult.WrongPassword;
        }

        public User FindUserFromUsername(string username)
        {
            ParagonDataContext ctx = new ParagonDataContext();

            return ctx.Users.FirstOrDefault(x => x.Username == username.ToLower());
        }

        private bool UsernameTooLong(string username) //TODO: Rename this. I can't think of the word I wanted to use.
        {
            return username.Length > 16;
        }

        private bool UsernameExists(string username)
        {
            return _context.Users.Any(x => x.Username.ToLower() == username.ToLower());
        }

        private bool EmailExists(string email)
        {
            return _context.Users.Any(x => x.Email.ToLower() == email.ToLower());
        }

        private bool IsInvalidEmail(string emailaddress)
        {
            return new EmailAddressAttribute().IsValid(emailaddress);
        }
    }
}
