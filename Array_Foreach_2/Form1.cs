using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Foreach_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[10];
            Random rastgele = new Random();
            for (int i = 0; i < 10; i++)
            {
                int uretilen_sayi = rastgele.Next(0, 51);
                sayilar[i] = uretilen_sayi;
            }
            foreach (int liste in sayilar)
            {
                listBox1.Items.Add(liste);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedIndex.ToString(); // Sıra
            textBox2.Text = listBox1.SelectedItem.ToString(); // Yazı
            object d1 = "Hello World";
            object d2 = 'A';
            object d3 = 123123124;
            object d4 = 6.7;
            object d5 = 22.4m;
            float ff = 63.7f;
            object d6 = ff; // Küçük veri tipinden büyüğe atama işlemi.
            float f1 = (float)d6; // Tam tersi cast işlemi yapılmadan hata verir.
         // string s1 = (string)d6; // Hatalı cast işlemidir.
        }
    }
}
// 10 elemanlı bir diziye 0 ile 50 arası sayılar üretilerek ekleyip ve listboxta        gösteren program.
// object c# içerisindeki tüm veri tiplerinin atasıdır.
// Cast İşlemi: Çevirilecek olan tipin hangi veri tipine ait olduğundan eminsek         yapılır. Genellikle büyük tipten küçük tipe atama yaptığımızda kullanılır.
// ListBox elemanları içinde object olarak tutar.