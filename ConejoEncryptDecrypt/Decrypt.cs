using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ConejoEncryptDecrypt
{
    public class Decrypt
    {
        public static string Password { get; set; }
        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string xDecryptText(string encrypted)
        {
            string result = "";
            byte[] Key = Encoding.UTF8.GetBytes(Password);

            string plaintext = null;
            // Create AesManaged
            using (AesManaged aes = new AesManaged())
            {
                aes.Key = Key;
                aes.IV = IV;
                // Create a decryptor
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] InputBytes = Convert.FromBase64String(encrypted);
                        cs.Write(InputBytes, 0, InputBytes.Length); 
                        cs.FlushFinalBlock();

                        byte[] OutputBytes = ms.ToArray();

                        result = Encoding.UTF8.GetString(OutputBytes);
                    }
                }
            }
            return result;
        }

        public static string DecryptText(string encrypted) {
            string decryptedText;
            byte[] Key = Encoding.UTF8.GetBytes(Password);
            byte[] cipherText = Convert.FromBase64String(encrypted); 

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decryptedText = sr.ReadToEnd();
                        }
                    }
                }
            }

            return decryptedText;
        }
    }
}
