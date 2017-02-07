using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Güvenli_E_Mail_Uygulaması
{
    class Crypto
    {
        
        //AES(Rijndael) Şifreleme
        public class AESSifreleme 
        { 

        private static byte[] _acık = Encoding.ASCII.GetBytes("jasdh7834y8hfeur73rsharks214");

        public static string AESsifreleme(string sifresizText, string gizlianahtar)
        {
            if (string.IsNullOrEmpty(sifresizText))
                throw new ArgumentNullException("sifresizText");
            if (string.IsNullOrEmpty(gizlianahtar))
                throw new ArgumentNullException("paylasilanGizli");

            string outStr = null;                       // Şifreli dize dönmek için
            RijndaelManaged aesAlg = null;              // RijndaelManaged nesne verileri şifrelemek için kullanılanılır.

            try
            {
                // paylaşılan gizli ve açık anahtarı oluşturma
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(gizlianahtar, _acık);

                // Bir RijndaelManaged nesnesi oluşturun
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Akış dönüşümü gerçekleştirmek için bir decryptor oluşturun.
                ICryptoTransform sifreleyici = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Şifreleme için kullanılan akışları oluşturun.
                using (MemoryStream msSifreleme = new MemoryStream())
                {

                    msSifreleme.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msSifreleme.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csSifreleme = new CryptoStream(msSifreleme, sifreleyici, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swSifreleme = new StreamWriter(csSifreleme))
                        {
                            //Akışa tüm veri yaz.
                            swSifreleme.Write(sifresizText);
                        }
                    }
                    outStr = Convert.ToBase64String(msSifreleme.ToArray());
                }
            }
            finally
            {
                // RijndaelManaged nesnesini temizleme
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Bellek akışı şifreli bayt dönme
            return outStr;
        }


        public static string AESSifreCozme(string sifreliText, string gizlianahtar)
        {
            if (string.IsNullOrEmpty(sifreliText))
                throw new ArgumentNullException("sifreliText");
            if (string.IsNullOrEmpty(gizlianahtar))
                throw new ArgumentNullException("gizlianahtar");

            // RijndaelManaged nesne bildirme
            // Verilerin şifresini çözmek için kullanılır.
            RijndaelManaged aesAlg = null;


            // Şifreli metin.
            string sifrelimetin = null;

            try
            {
                // paylaşılan gizli ve acık anahtarı oluşturmak
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(gizlianahtar, _acık);

                // Şifre çözme için kullanılan akışları oluşturma                
                byte[] bytes = Convert.FromBase64String(sifreliText);
                using (MemoryStream msSifrecozme = new MemoryStream(bytes))
                {

                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                    aesAlg.IV = byteDiziOku(msSifrecozme);

                    ICryptoTransform sifrecozucu = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csSifrecozucu = new CryptoStream(msSifrecozme, sifrecozucu, CryptoStreamMode.Read))
                    {
                        using (StreamReader srSifrecozucu = new StreamReader(csSifrecozucu))


                            sifrelimetin = srSifrecozucu.ReadToEnd();
                    }
                }
            }
            finally
            {

                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return sifrelimetin;
        }

        private static byte[] byteDiziOku(Stream s)
        {
            byte[] hamuzunluk = new byte[sizeof(int)];
            if (s.Read(hamuzunluk, 0, hamuzunluk.Length) != hamuzunluk.Length)
            {
                throw new SystemException("Akış düzgün biçimlendirilmiş bayt dizisi içermiyor");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(hamuzunluk, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Düzgün bayt dizisi okumadın mı?");
            }

            return buffer;
        }
        }

        //RC4 Algoritması
        public static class RC4
        {
            public static string sifrele(string key, string data)
            {
                Encoding unicode = Encoding.Unicode;

                return Convert.ToBase64String(bitsifreleme(unicode.GetBytes(key), unicode.GetBytes(data)));
            }

            public static string sifrecoz(string key, string data)
            {
                Encoding unicode = Encoding.Unicode;

                return unicode.GetString(bitsifreleme(unicode.GetBytes(key), Convert.FromBase64String(data)));
            }

            public static byte[] bitsifreleme(byte[] key, byte[] data)
            {
                return sfrcikis(key, data).ToArray();
            }

            public static byte[] bitsifrecozme(byte[] key, byte[] data)
            {
                return sfrcikis(key, data).ToArray();
            }

            private static byte[] sfrsifirla(byte[] key)
            {
                byte[] s = Enumerable.Range(0, 256)
                    .Select(i => (byte)i)
                    .ToArray();

                for (int i = 0, j = 0; i < 256; i++)
                {
                    j = (j + key[i % key.Length] + s[i]) & 255;

                    Swap(s, i, j);
                }

                return s;
            }

            private static IEnumerable<byte> sfrcikis(byte[] key, IEnumerable<byte> data)
            {
                byte[] s = sfrsifirla(key);

                int i = 0;
                int j = 0;

                return data.Select((b) =>
                {
                    i = (i + 1) & 255;
                    j = (j + s[i]) & 255;

                    Swap(s, i, j);

                    return (byte)(b ^ s[(s[i] + s[j]) & 255]);
                });
            }

            private static void Swap(byte[] s, int i, int j)
            {
                byte c = s[i];

                s[i] = s[j];
                s[j] = c;
            }
        }


        // 3DES

        public class desSifreleyici
        {
            private static string _anahtar;



            public static string Key
            {
                set
                {
                    _anahtar = value;
                }
            }

         
            public static byte[] DesSifreleme(string Text, string anahtar)
            {
                TripleDES des = DESOlustur(anahtar);
                ICryptoTransform ct = des.CreateEncryptor();
                byte[] input = Encoding.Unicode.GetBytes(Text);
                return ct.TransformFinalBlock(input, 0, input.Length);
            }
            public static string DesSifreCozme(string Text, string anahtar)
            {
                byte[] b = Convert.FromBase64String(Text);
                TripleDES des = DESOlustur(anahtar);
                ICryptoTransform ct = des.CreateDecryptor();
                byte[] output = ct.TransformFinalBlock(b, 0, b.Length);
                return Encoding.Unicode.GetString(output);
            }
            static TripleDES DESOlustur(string anahtar)
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                TripleDES des = new TripleDESCryptoServiceProvider();
                des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(anahtar));
                des.IV = new byte[des.BlockSize / 8];
                return des;
            }
        }

        //MD5 Şifreleme 

        public class MD5Sifreleyici
        {

       
        private static string password = "1";

        private static byte[] Sifrele(byte[] SifresizVeri, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms,

            alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(SifresizVeri, 0, SifresizVeri.Length);
            cs.Close();

            byte[] sifrelenmisVeri = ms.ToArray();
            return sifrelenmisVeri;
        }

        private static byte[] SifreCoz(byte[] SifreliVeri, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(SifreliVeri, 0, SifreliVeri.Length);
            cs.Close();

            byte[] SifresiCozulmusVeri = ms.ToArray();
            return SifresiCozulmusVeri;
        }

        public static string TextSifrele(string sifrelenecekMetin)
        {
            byte[] sifrelenecekByteDizisi = System.Text.Encoding.Unicode.GetBytes(sifrelenecekMetin);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,

            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] SifrelenmisVeri = Sifrele(sifrelenecekByteDizisi,

                 pdb.GetBytes(32), pdb.GetBytes(16));

            return Convert.ToBase64String(SifrelenmisVeri);
        }

        public static string TextSifreCoz(string text)
        {
            byte[] SifrelenmisByteDizisi = Convert.FromBase64String(text);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,

                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,

            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] SifresiCozulmusVeri = SifreCoz(SifrelenmisByteDizisi,

                pdb.GetBytes(32), pdb.GetBytes(16));

            return System.Text.Encoding.Unicode.GetString(SifresiCozulmusVeri);
        }
        }

        // Rijndael Şifreleme
        public class RijndaelSifreleme { 
        public static string RjndaelSifrele(string InputText, string Password)
        {

            RijndaelManaged RijndaelCipher = new RijndaelManaged();
            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputText);
            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(PlainText, 0, PlainText.Length);

            cryptoStream.FlushFinalBlock();

            byte[] CipherBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            string EncryptedData = Convert.ToBase64String(CipherBytes);

            return EncryptedData;

        }

        public static string RijndaelSifreCozme(string InputText, string Password)
        {

            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] EncryptedData = Convert.FromBase64String(InputText);

            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream(EncryptedData);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

            byte[] PlainText = new byte[EncryptedData.Length];

            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

            memoryStream.Close();

            cryptoStream.Close();

            string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            return DecryptedData;

        }
      }

        // RC2 Şifreleme 

        public class RC2Sifreleme
        {
          public  static byte[] RC2_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
            {
                byte[] encryptedBytes = null;
                string salt = "D495560961CCCFE0";
                byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
                using (MemoryStream msStream = new MemoryStream())
                {
                    using (RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider())
                    {
                        RC2.KeySize = 128;
                        RC2.BlockSize = 64;
                        var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                        RC2.Key = key.GetBytes(RC2.KeySize / 8);
                        RC2.IV = key.GetBytes(RC2.BlockSize / 8);
                        RC2.Mode = CipherMode.CBC;
                        using (var cs = new CryptoStream(msStream, RC2.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                            cs.Close();
                        }
                        encryptedBytes = msStream.ToArray();
                    }
                }
                return encryptedBytes;
            }

          public  static byte[] RC2_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
            {
                byte[] decryptedBytes = null;
                string salt = "D495560961CCCFE0";
                byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
                using (MemoryStream msStream = new MemoryStream())
                {
                    using (RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider())
                    {
                        RC2.KeySize = 128;
                        RC2.BlockSize = 64;
                        var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                        RC2.Key = key.GetBytes(RC2.KeySize / 8);
                        RC2.IV = key.GetBytes(RC2.BlockSize / 8);
                        RC2.Mode = CipherMode.CBC;
                        using (var cs = new CryptoStream(msStream, RC2.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                            cs.Close();
                        }
                        decryptedBytes = msStream.ToArray();
                    }
                }
                return decryptedBytes;
            }
          public  static string RC2Sfrele(string message, string password)
            {
                byte[] byresToBeEncrypted = Encoding.UTF8.GetBytes(message);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] bytesToBeEncrypted = RC2_Encrypt(byresToBeEncrypted, passwordBytes);
                string result = Convert.ToBase64String(byresToBeEncrypted);
                return result;
            }

           public static string RC2SifreCoz(string message, string password)
            {
                byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(message);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] bytesToBeDecrypted = RC2_Decrypt(bytesToBeEncrypted, passwordBytes);
                string result = Encoding.UTF8.GetString(bytesToBeDecrypted);
                return result;
            }
        }

    }

}
