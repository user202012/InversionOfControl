using System;
using System.Threading;


    public class Hasher
    {
        private IAlgorithm algoritm;

        public Hasher(IAlgorithm algorithm)
        {
            algoritm = algorithm;
        }

        public void Print(string text)
        {
            DoHash(text);
        }

        private void DoHash(string text)
        {
            Console.WriteLine(algoritm.Hash(text));
        }
    }
