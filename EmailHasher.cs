using System;
using System.Security.Cryptography;
using System.Text;

namespace BuzzLock
{
    public static class EmailHasher
    {
        public static string HashEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return string.Empty;

            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(email.ToLower().Trim());
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
