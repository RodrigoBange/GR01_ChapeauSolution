using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ChapeauLogic
{
    public class PasswordService
    {
        // Create new password
        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            // Create new RandomNumberGenerator object
            RandomCryptoGenerator rngGenerator = new RandomCryptoGenerator();

            // Generate random Salt
            byte[] saltBytes = rngGenerator.GenerateRandomCryptographicBytes(saltLength);

            // Transfer password to bytes
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);

            // Create new list and set range
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);

            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());

            // Return hashed result
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        // Converts password
        public HashWithSaltResult ConvertedHashWithSalt(string password, string salt)
        {
            // Transfer password and salt to bytes
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltBytes = Convert.FromBase64String(salt);

            // Combine password and salt bytes into a byte list
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);

            // Create a new Hash Algorithm
            HashAlgorithm hashAlgorithm = SHA256.Create();

            // Create a hash with the list
            byte[] digestBytes = hashAlgorithm.ComputeHash(passwordWithSaltBytes.ToArray());

            // Create a new HashWithSaltResult object and return
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        // Check if password is correct
        public bool CheckPassword(Employee employee, string employeePassword)
        {
            // Encrypt password
            PasswordService pwHasher = new PasswordService();
            HashWithSaltResult convertedHash = pwHasher.ConvertedHashWithSalt(employeePassword, employee.Salt);
            string convertedPassword = convertedHash.Digest;

            // Check if entered password is correct password
            if (convertedPassword == employee.Hash)
            {
                // Succesfully logged in
                return true;
            }
            else
            {
                // Incorrect password
                return false;
            }
        }
    }
}
