using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Drawing.Imaging;
using DHAF;


namespace Güvenli_E_Mail_Uygulaması
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = null;
        private string extractedText = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void algoritmacb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algoritmacb.Text.StartsWith("MD5"))
            {
                anahtargroup.Visible = false;
            }
            else
            {
                anahtargoster.Visible = true;
                anahtargroup.Visible = true;
            }
        }
        private void sifrelebtn_Click(object sender, EventArgs e)
        {
            if (algoritmacb.Text == "AES")
            {
                string text = sifresizmesaj.Text;

                if (text.Equals(String.Empty))
                {
                    MessageBox.Show("Gizlemek İstediğiniz Metni Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (anahtartxt.Text.Length < 6)
                {
                    MessageBox.Show("En az 6 Karakter İçeren Bir Şifre Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    text = Crypto.AESSifreleme.AESsifreleme(text, anahtartxt.Text);
                }
                sifrelimesaj.Text = text;
            }
            else if (algoritmacb.Text == "RC4")
            {
                string text = sifresizmesaj.Text;

                if (text.Equals(String.Empty))
                {
                    MessageBox.Show("Gizlemek İstediğiniz Metni Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (anahtartxt.Text.Length < 6)
                {
                    MessageBox.Show("En az 6 Karakter İçeren Bir Şifre Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    text = Crypto.RC4.sifrele(anahtartxt.Text, text);
                }
                sifrelimesaj.Text = text;
            }
            else if (algoritmacb.Text == "3DES")
            {
                string text = sifresizmesaj.Text;

                if (text.Equals(String.Empty))
                {
                    MessageBox.Show("Gizlemek İstediğiniz Metni Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (anahtartxt.Text.Length < 6)
                {
                    MessageBox.Show("En az 6 Karakter İçeren Bir Şifre Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    byte[] buffer = Crypto.desSifreleyici.DesSifreleme(text, anahtartxt.Text);
                    string b = Convert.ToBase64String(buffer);
                    text = b;
                }

                sifrelimesaj.Text = text;
            }
            else if (algoritmacb.Text == "Rijndael")
            {
                string text = sifresizmesaj.Text;

                if (text.Equals(String.Empty))
                {
                    MessageBox.Show("Gizlemek İstediğiniz Metni Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (anahtartxt.Text.Length < 6)
                {
                    MessageBox.Show("En az 6 Karakter İçeren Bir Şifre Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    text = Crypto.RijndaelSifreleme.RjndaelSifrele(text, anahtartxt.Text);
                }

                sifrelimesaj.Text = text;
            }
            else if (algoritmacb.Text == "RC2")
            {
                string text = sifresizmesaj.Text;

                if (text.Equals(String.Empty))
                {
                    MessageBox.Show("Gizlemek İstediğiniz Metni Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (anahtartxt.Text.Length < 6)
                {
                    MessageBox.Show("En az 6 Karakter İçeren Bir Şifre Giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    text = Crypto.RC2Sifreleme.RC2Sfrele(text, anahtartxt.Text);
                }

                sifrelimesaj.Text = "RjcA" + text;
            }

            else if (algoritmacb.Text == "MD5")
            {
                sifrelimesaj.Text = Crypto.MD5Sifreleyici.TextSifrele(sifresizmesaj.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Şifreleme Algoritması Seçiniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sifrecozbtn_Click(object sender, EventArgs e)
        {
            if (algoritmacb.Text == String.Empty)
            {
                MessageBox.Show("Lütfen Algoritma Türünü Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (algoritmacb.Text == "AES")
            {
                string cıkarılmısmetin = sifrelimesaj.Text.ToString();

                try
                {
                    cıkarılmısmetin = Crypto.AESSifreleme.AESSifreCozme(cıkarılmısmetin, anahtartxt.Text);
                }
                catch
                {
                    MessageBox.Show("Yanlış Şifre. Lütfen Doğru Anahtarı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                sifresizmesaj.Text = cıkarılmısmetin;

            }

            else if (algoritmacb.Text == "RC4")
            {
                string cıkarılmısmetin = sifrelimesaj.Text.ToString();

                try
                {
                    cıkarılmısmetin = Crypto.RC4.sifrecoz(anahtartxt.Text, cıkarılmısmetin);
                }
                catch
                {
                    MessageBox.Show("Yanlış Şifre. Lütfen Doğru Anahtarı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                sifresizmesaj.Text = cıkarılmısmetin;
            }
            else if (algoritmacb.Text == "3DES")
            {
                string cıkarılmısmetin = sifrelimesaj.Text.ToString();

                try
                {
                    cıkarılmısmetin = Crypto.desSifreleyici.DesSifreCozme(cıkarılmısmetin, anahtartxt.Text);
                }
                catch
                {
                    MessageBox.Show("Yanlış Şifre. Lütfen Doğru Anahtarı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                sifresizmesaj.Text = cıkarılmısmetin;
            }
            else if (algoritmacb.Text == "Rijndael")
            {
                string cıkarılmısmetin = sifrelimesaj.Text.ToString();

                try
                {
                    cıkarılmısmetin = Crypto.RijndaelSifreleme.RijndaelSifreCozme(cıkarılmısmetin, anahtartxt.Text);
                }
                catch
                {
                    MessageBox.Show("Yanlış Şifre. Lütfen Doğru Anahtarı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                sifresizmesaj.Text = cıkarılmısmetin;
            }
            else if (algoritmacb.Text == "RC2")
            {
                string cıkarılmısmetin = sifrelimesaj.Text.ToString();

                try
                {
                    cıkarılmısmetin = Crypto.RC2Sifreleme.RC2SifreCoz(cıkarılmısmetin, anahtartxt.Text);
                }
                catch
                {
                    MessageBox.Show("Yanlış Şifre. Lütfen Doğru Anahtarı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                sifresizmesaj.Text = cıkarılmısmetin;
            }
            else if (algoritmacb.Text == "MD5")
            {
                sifresizmesaj.Text = Crypto.MD5Sifreleyici.TextSifreCoz(sifrelimesaj.Text);
            }
        }
        private string smalldecimal(string inp, int dec)
        {
            int i;
            for (i = inp.Length - 1; i > 0; i--)
                if (inp[i] == '.')
                    break;
            try
            {
                return inp.Substring(0, i + dec + 1);
            }
            catch
            {
                return inp;
            }
        }

        private void resimsecbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimekle = new OpenFileDialog();
            resimekle.Title = "Resim Seç";
            resimekle.Filter = "(*.bmp)|*.bmp";

            if (resimekle.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(resimekle.OpenFile());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                boyutlbl.Text = pictureBox1.Image.Size.ToString();
                yuksekliklbl.Text = pictureBox1.Image.Height.ToString() + " Pixel";
                genisliklbl.Text = pictureBox1.Image.Width.ToString() + " Pixel";

                FileInfo imginf = new FileInfo(resimekle.FileName);
                float fs = (float)imginf.Length / 1024;
                boyutlbl.Text = smalldecimal(fs.ToString(), 2) + " KB";

                int Depth = System.Drawing.Bitmap.GetPixelFormatSize(pictureBox1.Image.PixelFormat);
                if (Depth < 9)
                {
                    MessageBox.Show("Resim Pixel Formatı Çok Düşük. Lütfen Farklı Bir Resim Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Image = null;
                    return;
                }
            }
        }
        private void resimkaydetbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sfd.Filter = "(*.bmp)|*.bmp";
                sfd.Title = "Resimi Kayıt";
                sfd.FileName = "Şifreli Resim";

                DialogResult sonuc = sfd.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName);
                    MessageBox.Show("Resim Kaydedildi. ", "TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void mailaktarbtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                tabControl1.SelectedTab = tabPage2;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

            algoritmacb.Items.Add("3DES");
            algoritmacb.Items.Add("AES");
            algoritmacb.Items.Add("Rijndael");
            algoritmacb.Items.Add("RC4");
            algoritmacb.Items.Add("RC2");
            algoritmacb.Items.Add("MD5");

            if (pixelgoster.Checked)
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void gizlebtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Alanı Boş. Lüfen Bir Resim Seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bmp = (Bitmap)pictureBox1.Image;

                string text = sifrelimesaj.Text;

                if (text.Equals(String.Empty))
                {
                    MessageBox.Show("Gizlemek istediğiniz metni boş olamaz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if (anahtartxt.Text.Length < 6)
                {
                    MessageBox.Show("En az 6 karakterden oluşan bir parola giriniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                else
                    /*{
                        text = Crypto.AESSifreleme.AESsifreleme(text, anahtartxt.Text);
                    }*/

                    bmp = Steganography.embedText(text, bmp);

                MessageBox.Show("Metin görüntüye başarıyla gizlendi !", "Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cıkarbtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen Resim Seçiniz. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bmp = (Bitmap)pictureBox1.Image;

                string cıkarılmısmetin = Steganography.metnicıkar(bmp);


                try
                {
                    cıkarılmısmetin = Crypto.AESSifreleme.AESSifreCozme(cıkarılmısmetin, anahtartxt.Text);
                }
                catch
                {
                    MessageBox.Show("Yanlış Şifre. Lütfen Doğru Anahtarı Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                sifrelimesaj.Text = cıkarılmısmetin;


            }
        }

        private void mailgonderbtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress(gondericimailadresi.Text + "@hotmail.com");
                //E-Posta'nin kimden gönderilecegi bilgisini tutar. MailAddress türünden bir degisken istemektedir.
                ePosta.To.Add(alicimail.Text);
                // E-Postanin kime/kimlere gönderilecegi bilgisini tutar.

                MemoryStream ms = new MemoryStream();

                pictureBox1.Image.Save(ms, ImageFormat.Bmp);
                // Attachment eklenti = new Attachment(pictureBox2.ImageLocation);
                ePosta.Attachments.Add(new Attachment(ms, "image/bmp"));  // E-Postaya eklenecek eklentilerin bilgisini tutar.  @"C:\deneme.txt"

                ePosta.Subject = mesajkonusu.Text;

                ePosta.Body = mesaj.Text;

                SmtpClient smtp = new SmtpClient();
                /*E-Posta'nin gönderilecegi SMTP sunucu ve gönderen kullanicinin bilgilerinin yazilip, 
            MailMessage türünde olusturulan mailin gönderildigi siniftir.*/

                smtp.Credentials = new System.Net.NetworkCredential(gondericimailadresi.Text, mailsifre.Text); //E-Posta'yi gönderen kullanicinin kimlik bilgilerini tutar.

                smtp.Port = 587;

                smtp.Host = "smtp.live.com";

                smtp.EnableSsl = true;

                smtp.Timeout = 50000;


                object userState = ePosta;

                // bool kontrol = true;  

                try
                {
                    smtp.SendAsync(ePosta, (object)ePosta);
                    /*E-Posta'yi asenkron olarak gönderir.
                    Yani e-posta gönderilene kadar çalisan thread kapanmaz, gönderme islemi tamamlandiktan sonra kapatilir.*/
                    MessageBox.Show("Mail Gönderildi.", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException ex)
                {
                    //  kontrol = false;
                    MessageBox.Show(ex.Message, "Mail Gönderme Hatasi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // return kontrol;
            }
            catch
            {
                MessageBox.Show("Bilgiler Eksik Veya Hatalı. \nBilgilerinizi Kontrol Ediniz. \nGirdilerin Eksiksiz Olduğundan Emin Olunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kriptomail_Click(object sender, EventArgs e)
        {
            if (sifrelimesaj.Text == String.Empty)
            {
                MessageBox.Show("Şifreli Mesaj Alanı Boş!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mesaj.Text = sifrelimesaj.Text;
                tabControl1.SelectedTab = tabPage2;
            }
        }
        private void anahtaruret_Click(object sender, EventArgs e)
        {
            string anahtar = Guid.NewGuid().ToString("N");
            anahtartxt.Text = anahtar;
        }
        private void anahtargoster_CheckedChanged(object sender, EventArgs e)
        {
            if (anahtargoster.Checked)
            {
                anahtartxt.UseSystemPasswordChar = false;
            }
            else
            {
                anahtartxt.UseSystemPasswordChar = true;
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void sifrelimesaj_TextChanged(object sender, EventArgs e)
        {


        }

        clsExtract obj1 = new clsExtract();
        private void tabHide_Click(object sender, EventArgs e)
        {

            
        }

        private void tabgizle(object sender, TabControlEventArgs e)
        {
            
        }

        private void tabgiris(object sender, EventArgs e)
        {
            listBox1.Items.Add("1.Şifrelenecek Ses Dosyası Seçin.");
            listBox1.Items.Add("2.Yeni Text Dosyası Girişi");
            listBox1.Items.Add("3.Anahtar Dosya Girişi");
            listBox1.Items.Add("4.Doğrulama Ayarları");
            listBox1.Items.Add("5.Ses verileri ayıklanıyor.");
            listBox1.Items.Add("6.Çıktı metin dosyası görüntüleme.");
            listBox1.SelectedIndex = 0;
        }


    }    

  }
    




      

 
    
  

