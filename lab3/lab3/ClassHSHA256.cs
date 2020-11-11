using System;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.IO;


    public class HSHA256 : IAlgorithm
    {
        public string Hash(string input)
        {
            SHA256 SHA256 = SHA256.Create();
            byte[] data = SHA256.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public override string ToString()
        {
            return nameof(SHA256);
        }
    }

