using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReturnCcryptographic
{
    class Program
    {
        static void Main(string[] args)
        {
            string samData = "testtest";
            Cryptographic.GenerateHashAlgo("C:\\Users\\Desktop\\file.txt", samData);
        }
    }
    public class Cryptographic
    {
       

        public static byte[] GenerateHashAlgo(string fileName, string HashAlgor)
        {
            var signnatureAlgo = HashAlgorithm.Create(HashAlgor);
            var fileBuffer = System.IO.File.ReadAllBytes(fileName);
            return signnatureAlgo.ComputeHash(fileBuffer);
        }
    }
}
