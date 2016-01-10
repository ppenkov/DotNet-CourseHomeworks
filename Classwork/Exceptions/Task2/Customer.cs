using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Customer
    {
        private string email;

        public string Email
        {
            get { return email; }
            set
            {

                if (CheckEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new InvalidE_mail("Invalid email");
                }
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (CheckPassword(value))
                {
                    this.password = value;
                }
                else
                {
                    throw new InvalidPassword("Invalid password");
                }

            }
        }

        public Customer ()
        {

        }

        public Customer(string email, string password)
        {

        }

        private bool CheckEmail(string email)
        {
            if (email.Length > 5 && email.Contains('@') && email.Contains('.'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckPassword(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
