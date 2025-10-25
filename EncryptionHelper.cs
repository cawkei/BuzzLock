using System;
using System.Security.Cryptography;
using System.Text;

namespace BuzzLock
{
    public static class EncryptionHelper
    {
        public static string EncryptString(string plain)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plain);
            byte[] protectedBytes = ProtectedData.Protect(plainBytes, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(protectedBytes);
        }

        public static string DecryptString(string cipherBase64)
        {
            byte[] protectedBytes = Convert.FromBase64String(cipherBase64);
            byte[] plainBytes = ProtectedData.Unprotect(protectedBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
