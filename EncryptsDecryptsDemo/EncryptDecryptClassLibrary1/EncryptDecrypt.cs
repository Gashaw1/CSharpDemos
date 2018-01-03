using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecryptClassLibrary1
{
    public class EncryptDecrypt
    {
        //do encrypt
        public static string Do_Encrypt<T>(T DecryptValue, T salt)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(DecryptValue.ToString());

            using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
            {
                byte[] keys = mds.ComputeHash(UTF8Encoding.UTF8.GetBytes(salt.ToString()));

                using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7

                })
                {
                    ICryptoTransform trnsform = trip.CreateEncryptor();
                    byte[] results = trnsform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);

                }
            }
        }
        //do decrypt
        public static string Do_Decrypt<T>(T EncryptValue, T salt)
        {
            byte[] data = Convert.FromBase64String(EncryptValue.ToString());

            using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
            {
                byte[] keys = mds.ComputeHash(UTF8Encoding.UTF8.GetBytes(salt.ToString()));
                using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform trnsform = trip.CreateDecryptor();
                    byte[] results = trnsform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
     
        public static string CreateSalt(int size)
        {
            var rang = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rang.GetBytes(buff);
            string str = Convert.ToBase64String(buff);
            return str;
        }

    }
}

