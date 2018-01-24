using System;
using System.Security.Cryptography;

namespace Examples.SRP
{
    public class CryptoProvider
    {
        public string EncryptWithAes(string original)
        {
            using (Aes myAes = Aes.Create())
            {

                // Encrypt the string to an array of bytes.
                // encPassword = EncryptString_Aes(password, myAes.Key, myAes.IV);
                // encUsername = EncryptString_Aes(userName, myAes.Key, myAes.IV);

                return "encrypted";
            }
        }
    }
}