using System;
using System.Text;
using Konscious.Security.Cryptography;
using CryptSharp.Utility;

namespace BuzzLock
{
    public static class PasswordHasher
    {
        public static string HashWithArgon2(string password)
        {
            var salt = Encoding.UTF8.GetBytes(Guid.NewGuid().ToString());
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = 8,  // CPU cores
                MemorySize = 65536,    // 64 MB
                Iterations = 4
            };

            byte[] hash = argon2.GetBytes(32);
            return $"$argon2${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        }

        public static string HashWithScrypt(string password)
        {
            byte[] salt = Encoding.UTF8.GetBytes(Guid.NewGuid().ToString());

            byte[] hash = SCrypt.ComputeDerivedKey(
                Encoding.UTF8.GetBytes(password),
                salt,
                16384, // Cost
                8,     // Block size
                1,     // Parallelism
                null,  // Max threads
                32);   // Derived key length (int)

            return $"$scrypt${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        }
    }
}