#region Libraries
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
#endregion Libraries
#region NameSpace
namespace Dilan
{
    #region Comments
    // Github Account
    // Sign up with a username, password and email address
    // Password must be 'strong' (what are the requirements of a strong password?)

    //              Access                                          AbilityToChange
    // UserName     Public                                          No
    // Password     Private (can be emailed if forgotten)           Yes, if logged in or with email address
    // Email        Private                                         Yes, if logged in
    // Code         Public                                          Yes, if logged in
    #endregion Comments
    #region Class
    class GithubAccount
    {
        private string _password;
        private string _emailAddress;
        private string _code;
        private string _userName;
        private bool isLoggedIn = false;


        public GithubAccount(string password, string emailAddress, string username)
        {
            _password = password;
            _emailAddress = emailAddress;
            _userName = username;
        }

        public string UserName { get; }

        public string Code
        {
            get { return _code; }

            set
            {
                if (isLoggedIn == true) _code = value;

                else if (_emailAddress != null) _code = value;
            }

        }

        public string EmailAddress
        {
            get { if (isLoggedIn == true) return _emailAddress;
                else return null;
        }

            set
            {
                if (isLoggedIn == true) _code = value;
            }
        }

        public string Password
        {
            get
            {
                Console.WriteLine("What is your email?");
                var email = Console.ReadLine();

                if (email == _emailAddress)
                    return $"Your password is: {_password}";
                else
                    return "Incorrect email!";
            }

            set
            {
                if (isLoggedIn == true) _code = value;
            }
        }

        public string LogIn()
        {
            isLoggedIn = true;
            return $"your login status is: {isLoggedIn}";
        }


        public string Hash(string Item)
        {
            //taken from the Missile Class
            var encrypted = Item.ToCharArray().Select(character => (int)character).ToArray();
            return String.Join('-', encrypted);
        }

    }
    #endregion Class
}

#endregion NameSpace
