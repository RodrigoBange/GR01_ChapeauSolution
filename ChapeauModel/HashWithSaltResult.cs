using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class HashWithSaltResult
    {
        // Properties
        public string Salt { get; }
        public string Digest { get; set; }

        // Constructor
        public HashWithSaltResult(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }
}
