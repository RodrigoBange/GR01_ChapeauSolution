using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ChapeauLogic
{
    public class RandomCryptoGenerator
    {
        public string GenerateRandomCryptographicKey(int keyLength)
        {
            // Return string
            return Convert.ToBase64String(GenerateRandomCryptographicBytes(keyLength));
        }

        public byte[] GenerateRandomCryptographicBytes(int keyLength)
        {
            // Create new RNGCryptoServiceProvider object
            RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();

            // Create array of bytes
            byte[] randomBytes = new byte[keyLength];

            // Get random bytes
            rngCryptoServiceProvider.GetBytes(randomBytes);

            // Return array of bytes
            return randomBytes;
        }
    }
}
