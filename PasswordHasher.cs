using CryptSharp.Utility;
using Konscious.Security.Cryptography;
using System;
using System.Security.Cryptography;
using System.Text;

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

        public static bool Verify(string password, string storedHash)
        {
            try
            {
                var parts = storedHash.Split('$', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 3)
                    return false;

                string algorithm = parts[0];
                byte[] salt = Convert.FromBase64String(parts[1]);
                byte[] storedBytes = Convert.FromBase64String(parts[2]);
                byte[] computedBytes;

                if (algorithm == "argon2")
                {
                    var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
                    {
                        Salt = salt,
                        DegreeOfParallelism = 8,
                        MemorySize = 65536,
                        Iterations = 4
                    };
                    computedBytes = argon2.GetBytes(32);
                }
                else
                {
                    return false;
                }

                return CryptographicOperations.FixedTimeEquals(storedBytes, computedBytes);
            }
            catch
            {
                return false;
            }
        }
    }
}