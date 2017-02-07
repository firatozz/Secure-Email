using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Güvenli_E_Mail_Uygulaması
{
    class Steganography
    {
        public enum durum
        {
            gizli, Filling_With_Zeros
        };

        public static Bitmap embedText(string text, Bitmap bmp)
        {
                      
            durum drm = durum.gizli;   // Başlangıçta, görüntüdeki karakterleri saklanıyor olacak

            int charIndex = 0;   // gizli olan karakterin dizinini tutar

            int charValue = 0; // karakter değeri tamsayı dönüştürülür tutar

            long pixelElementIndex = 0;  // Şu anda işlenen renk elemanının indeksi (R ya da G veya B) tutar

            int zeros = 0;    //  sondaki sıfırların sayısını tutar

            int R = 0, G = 0, B = 0;  // Tutulan piksel elemanları


            for (int i = 0; i < bmp.Height; i++)
            {              
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);   // Şu Anda işlenen piksel tutar

                    // her piksel elemanı en az önemli bit (LSB) temizleme
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

        
                    for (int n = 0; n < 3; n++)
                    {
                        // Yeni 8 bit işlenmiş olup olmadığını kontrol eder.
                        if (pixelElementIndex % 8 == 0)
                        {
                            // Tüm süreç bitmiş olup olmadığını kontrol edin
                            // Biz 8 sıfır eklendiğinde bu bitmiş olduğunu söyleyebiliriz
                            if (drm == durum.Filling_With_Zeros && zeros == 8)
                            {

                         // elementlerden sadece bir parçası etkilenmiş olsa bile Görüntünün son pikseli uygulama
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                         //    Gizli metini bitmap ile döndürme
                                return bmp;
                            }

                            // Tüm karakterler gizli olup olmadığını kontrol eder
                            if (charIndex >= text.Length)
                            {
                          //    Metnin sonuna işaretlemek için sıfır ekleyerek başlar
                                drm = durum.Filling_With_Zeros;
                            }
                            else
                            {
                          //  Tekrar sonraki karaktere ve süreç taşıma
                                charValue = text[charIndex++];
                            }
                        }

               
                        //  LSB den alınan bitlerin hangi piksel elemanları oldugunu kontrol eder
                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (drm == durum.gizli)
                                    {
                                        /* en sağdaki bit karakter (charValue % 2)
                                        Bu değer yerine piksel öğe LSB koyma                                    
                                        LSB piksel öğesinin işaretli hatırlama */

                                        R += charValue % 2;

                                        // Karakter eklendi sağdaki bit kaldırıldı
                                        // Bir sonraki sefere ulaşabilmek için

                                        charValue /= 2;
                                    }
                                } break;
                            case 1:
                                {
                                    if (drm == durum.gizli)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                } break;
                            case 2:
                                {
                                    if (drm == durum.gizli)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }
                                 
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                } break;
                        }

                        pixelElementIndex++;

                        if (drm == durum.Filling_With_Zeros)
                        {
                           // 8 olana kadar sıfır değerini artırır
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
        }
        
        public static string metnicıkar(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            // Görüntüden elde edilecek metni tutar
            string cıkarılmısmetin = String.Empty;

      
            for (int i = 0; i < bmp.Height; i++)
            {        
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
            
                    for (int n = 0; n < 3; n++) // Her bir piksel için, kendi elemanları aracılığıyla (RGB) geçme
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    // Sonra geçerli karakterin sağında bir bit ekleme
                                    // Bu yapılabilir (charValue = charValue x 2)
                                    // Katma bit (değer varsayılan 0 olan) ile değiştirin
                                    // LSB piksel elemanının, sadece eklenmesiyle

                                    charValue = charValue * 2 + pixel.R % 2;
                                } break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                } break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                } break;
                        }
                        

                        colorUnitIndex++;

                        //8 bit eklenmişse sonra sonuç metni mevcut karakter eklemek
                        if (colorUnitIndex % 8 == 0)
                        {                      
                            charValue = tersBits(charValue);  // her zaman süreci sağda olur çünkü (basitlik için)
                                                     
                            if (charValue == 0)  // Durdurma karakteri sadece 0 olabilir (8 Sıfır)
                            {
                                return cıkarılmısmetin;
                            }                            
                            char c = (char)charValue;   // char - int karakter değeri dönüştürür
                            
                            cıkarılmısmetin += c.ToString();   // Sonuç metne geçerli bir karakter eklemek
                        }
                    }
                }
            }

            return cıkarılmısmetin;
        }

        public static int tersBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }

    }
}
