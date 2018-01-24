using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Examples.SRP
{
    public class UserRegistration
    {
        public void RegisterUserIntoApplication(string email, string password, string userName)
        {
            if (EmailValidation.validateEmail(email))
            {
				StoreCredentials.insertCredential(Encryption.encrypt(password,userName));
                EmailManager.sendEmail(email);
            }else
			{
				/*Don't mach*/
			}            
        }
    }
	
	public class EmailValidation
	{
		public static bool validateEmail(string email)
		{
			bool isValid = false;
            if (String.IsNullOrEmpty(email)) return;
            else
            {
                isValid = Regex.IsMatch(email,
                        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
			return isValid;
		}
	}
	
	public class EmailManager
	{
		public static void sendEmail(string email)
		{
			// send confirmation email
                string to = email;
                string from = "random@random.com";
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Your account has been activated";
                message.Body = "asdjasnjkldna asjkdbnasjk bna;lfk nal;g kan'flsgn a'lkgna";
                SmtpClient client = new SmtpClient("server");
                client.Send(message);
		}
	}	
	
	public class Encryption
	{
		public static string[] encrypt( string password, string userName)
		{
				string[] encDetails;
                using (Aes myAes = Aes.Create())
                {

                    // Encrypt the string to an array of bytes.
                     encDetails[0] = EncryptString_Aes(password, myAes.Key, myAes.IV).toString();
                     encDetails[1] = EncryptString_Aes(userName, myAes.Key, myAes.IV).toString();
                }
				return encDetails;
		}
	}
	
	public class StoreCredentials
	{
		public static void insertCredential(string[] encDetails )
		{
			var encPassword = encDetails[0];
			var encUsername =  encDetails[1];
				// store credentials and discount
                using (SqlConnection sql = new SqlConnection("connection-string"))
                {
                    sql.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "INSERT INTO ... ";
                    command.Parameters.Add(encPassword);
                    command.Parameters.Add(encUserName);
                    command.BeginExecuteNonQuery();
                }
		}
	}	
}
