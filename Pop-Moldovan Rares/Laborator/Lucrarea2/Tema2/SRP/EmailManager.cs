using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Examples.SRP
{
    public class EmailManager
    {
        public bool ValidateEmail(string email)
        {
            if (String.IsNullOrEmpty(email)) return false;
            else
            {
                return Regex.IsMatch(email,
                        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
        }

        public void SendConfirmationEmailToUser(string email)
        {
            string to = email;
            string from = "random@random.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Your account has been activated";
            message.Body = "asdjasnjkldna asjkdbnasjk bna;lfk nal;g kan'flsgn a'lkgna";
            SmtpClient client = new SmtpClient("server");
            client.Send(message);
        }
    }
}