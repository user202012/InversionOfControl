using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;


    public class HMD5 : IAlgorithm
    {
        public string Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public override string ToString()
        {
            return nameof(MD5);
        }
    }

