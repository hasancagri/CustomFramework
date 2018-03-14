using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NorthwindApp.Helpers.Utilities.Encryption
{
    public static class Encryptor
    {
        public static string Encrypt(string id)
        {
            //if (id == null)
            //{
            //    throw new ArgumentNullException("veri yok");
            //}
            //else
            //{
            //    byte[] aryKey = Byte8("15278596"); // 8 bit 
            //    byte[] aryIV = Byte8("15278596"); // 8 bit 
            //    DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            //    MemoryStream ms = new MemoryStream();
            //    CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(aryKey, aryIV), CryptoStreamMode.Write);
            //    StreamWriter writer = new StreamWriter(cs);
            //    writer.Write(id);
            //    writer.Flush();
            //    cs.FlushFinalBlock();
            //    writer.Flush();
            //    id = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            //    writer.Dispose();
            //    cs.Dispose();
            //    ms.Dispose();
            //}
            return id;
        }

        public static int Decrypt(string id)
        {
            //if (id == null)
            //{
            //    throw new ArgumentNullException("Veri Yok.");
            //}
            //else
            //{
            //    byte[] aryKey = Byte8("15278596");
            //    byte[] aryIV = Byte8("15278596");
            //    DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            //    MemoryStream ms = new MemoryStream(Convert.FromBase64String(id));
            //    CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(aryKey, aryIV), CryptoStreamMode.Read);
            //    StreamReader reader = new StreamReader(cs);
            //    id = reader.ReadToEnd();
            //    reader.Dispose();
            //    cs.Dispose();
            //    ms.Dispose();
            //}
            return Convert.ToInt32(id);
        }

        private static byte[] StringToByte(string deger)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            return ByteConverter.GetBytes(deger);
        }

        private static byte[] Byte8(string deger)
        {
            char[] arrayChar = deger.ToCharArray();
            byte[] arrayByte = new byte[arrayChar.Length];
            for (int i = 0; i < arrayByte.Length; i++)
            {
                arrayByte[i] = Convert.ToByte(arrayChar[i]);
            }
            return arrayByte;
        }
    }
}
