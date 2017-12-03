using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHashCode
{
    public class CalcHashCode
    {
        byte[] hashA;
        byte[] hashB;
        string data = "sample texts one";
        string data2 = "sample texts one";

        void CreateHash()
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();

            hashA = sha256.ComputeHash(byteConverter.GetBytes(data));
            hashB = sha256.ComputeHash(byteConverter.GetBytes(data2));
        }
        public bool Equal()
        {
            CreateHash();
            return hashA.SequenceEqual(hashB); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CalcHashCode calHash = new CalcHashCode();
            var result = calHash.Equal();
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
