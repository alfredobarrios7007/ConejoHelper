using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Net;

namespace ConejoEncryptDecrypt
{
    public class Encrypt
    {
        public static string Password { get; set; }

        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static string EncryptionText(string textToEcrypt) {
            string result = "";
            byte[] Key = Encoding.UTF8.GetBytes(Password);
            using (AesManaged aes = new AesManaged())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] InputBytes = Encoding.UTF8.GetBytes(textToEcrypt);
                        cs.Write(InputBytes, 0, InputBytes.Length);
                        cs.FlushFinalBlock();
                        byte[] Encrypted = ms.ToArray();
                        result = Convert.ToBase64String(Encrypted);
                    }
                }
            }
            return result;
        }
    }
}
