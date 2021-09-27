using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace EJ4
{
    class EncriptadorAES : Encriptador
    {
        public EncriptadorAES():
            base("AES")
        {

        }

        // Procesos para encriptar y desencriptar sacados
        // de: https://www.c-sharpcorner.com/article/aes-encryption-in-c-sharp/#:~:text=NET%20and%20C%23.,to%20encrypt%20and%20decrypt%20data.

        public override string Encriptar(string pCadena)
        {
            byte[] encrypted;
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(pCadena);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return System.Text.Encoding.UTF8.GetString(encrypted);
        }

        public override string Desencriptar(string pCadena)
        {
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] cadenaEncriptada = Encoding.UTF8.GetBytes(pCadena);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cadenaEncriptada))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }
    }
}
