using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Examples.SRP
{
    public class SingleResponsabilityPrinciple
    {
        private EmailManager _emailManager;
        private CryptoProvider _cryptoProvider;
        private DataAccessLayer _dal;

        public SingleResponsabilityPrinciple(EmailManager emailManager, CryptoProvider cryptoProvider, DataAccessLayer dal)
        {
            _emailManager = emailManager;
            _cryptoProvider = cryptoProvider;
            _dal = dal;
        }

        public void RegisterUserIntoApplication(string password, string userName, string email)
        {
            if (_emailManager.ValidateEmail(email))
            {
                _dal.StoreUserInfo(_cryptoProvider.EncryptWithAes(password), _cryptoProvider.EncryptWithAes(userName));
                _emailManager.SendConfirmationEmailToUser(email);
            }
        }
    }
}
