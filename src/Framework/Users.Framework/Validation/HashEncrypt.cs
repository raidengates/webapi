namespace Users.Framework.Validation
{
    using System;
    public class HashEncrypt
    {
        public  string CreateSaltPerUser(string UserName, string GlobalSalt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(string.Concat(UserName, GlobalSalt));
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public  string GenerateSHA256Hash(string input, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring =
                new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public  bool AreEqual(string plainTextInput, string hashedInput, string salt)
        {
            string newHashedPin = GenerateSHA256Hash(plainTextInput, salt);
            return newHashedPin.Equals(hashedInput);
        }
    }
}
