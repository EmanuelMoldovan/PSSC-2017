using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Modele.Generic
{
    public class Email
    {
        private string emailString;
        public string Valoare { get { return emailString; } }

        public Email(string emailText)
        {
            Contract.Requires<ArgumentException>(emailText != "", "valoare");
            Contract.Requires<ArgumentException>(emailText.Length > 100, "valoare");

            emailString = emailText;
        }

        #region override object
        public bool IsValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}", Valoare);
        }
    }
}
