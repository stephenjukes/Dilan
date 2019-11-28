using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Encapsulation
{
    class MyAccount
    {
        // Github Account
        // Sign up with a username, password and email address
        // Password must be 'strong' (what are the requirements of a strong password?)

        //              Access                                          AbilityToChange
        // UserName     Public                                          No
        // Password     Private (can be emailed if forgotten)           Yes, if logged in or with email address
        // Email        Private                                         Yes, if logged in
        // Code         Public                                          Yes, if logged in


        private string _password;
        private string _memorableQuestion;
        private string _memorableInformation;

        public MyAccount(string name, string password, string memorableQuestion, string memorableInformation)
        {
            Name = name;
            Password = password;
            _memorableQuestion = memorableQuestion;
            _memorableInformation = memorableInformation;
        }

        public string Name { get; }

        public string Password
        {
            get
            {
                Console.WriteLine($"Answer this question to recover your password...\n - {_memorableQuestion}");
                var answer = Console.ReadLine();

                return answer == _memorableInformation
                    ? $"Your password is: {_password}"
                    : "Sorry, your answer is not correct";
            }

            set
            {
                var hasNumber = new Regex(@"\d").IsMatch(value);
                var hasUpperCase = new Regex(@"[A-Z]").IsMatch(value);
                var hasLowerCase = new Regex(@"[a-z]").IsMatch(value);
                var hasNonAlphaNumeric = new Regex(@"\W").IsMatch(value);
                var isValidPassword = hasNumber && hasUpperCase && hasLowerCase && hasNonAlphaNumeric;

                if (isValidPassword)
                    _password = value;
                else
                    Console.WriteLine("Password must contain at least 1 number, uppercase, lowercase and nonalphanumeric");
            }
        }

        public bool ChangeMemorableInformation(string password, string memorableQuestion, string memorableInformation)
        {
            if (password == _password)
            {
                _memorableQuestion = memorableQuestion;
                _memorableInformation = memorableInformation;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
