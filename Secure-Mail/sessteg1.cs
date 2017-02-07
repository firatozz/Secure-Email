using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Güvenli_E_Mail_Uygulaması
{
    public partial class sessteg1 : Form
    {
        public sessteg1()
        {
            InitializeComponent();
        }

        private void sessteg1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("1.Şifrelenecek Ses Dosyası Seçin.");
            listBox1.Items.Add("2.Yeni Text Dosyası Girişi");
            listBox1.Items.Add("3.Anahtar Dosya Girişi");
            listBox1.Items.Add("4.Doğrulama Ayarları");
            listBox1.Items.Add("5.Ses verileri ayıklanıyor.");
            listBox1.Items.Add("6.Çıktı metin dosyası görüntüleme.");
            listBox1.SelectedIndex = 0;

           // obj1 = new clsExtract();
        }
    }
}
