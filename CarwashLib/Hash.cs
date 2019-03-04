using System;
using System.Security.Cryptography;
using System.Text;

namespace CarwashLib
{
    public class Hash
    {
        public static byte[] GenerateSalt()
        {
            const int saltLength = 32;

            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        private static byte[] Combine(byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];

            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);

            return ret;
        }

        public static byte[] HashPasswordWithSalt(string toBeHashed, byte[] salt, int amountOfRepitions)
        {
            return HashPasswordWithSalt(Encoding.UTF8.GetBytes(toBeHashed), salt, amountOfRepitions);
        }

        public static byte[] HashPasswordWithSalt(byte[] toBeHashed, byte[] salt, int amountOfRepitions)
        {
            byte[] hash;

            using (var sha256 = SHA256.Create())
            {
                hash = sha256.ComputeHash(Combine(toBeHashed, salt));
            }

            return HashPasswordWithSalt(ref hash, salt, --amountOfRepitions);
        }

        private static byte[] HashPasswordWithSalt(ref byte[] hash, byte[] salt, int amountOfRepitions)
        {
            if (amountOfRepitions <= 0)
                return hash;

            using (var sha256 = SHA256.Create())
            {
                hash = sha256.ComputeHash(Combine(hash, salt));
            }

            return HashPasswordWithSalt(ref hash, salt, --amountOfRepitions);
        }
    }
}
