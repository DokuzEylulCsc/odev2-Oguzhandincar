using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            int sayi = Convert.ToInt32(textBox3.Text);
            int binler = sayi / 1000;
            int yüzler = (sayi % 1000) / 100;
            int onlar = ((sayi % 1000) % 100) / 10;
            int birler = ((sayi % 1000) % 100) % 10;
            if (sayi<4000)
            {
                switch (binler)
                {
                    case 1: label1.Text = "M"; break;
                    case 2: label1.Text = "MM"; break;
                    case 3: label1.Text = "MMM"; break;

                      
                }
                switch (yüzler)
                {
                    case 1: label1.Text = label1.Text + "C"; break;
                    case 2: label1.Text = label1.Text + "CC"; break;
                    case 3: label1.Text = label1.Text + "CCC"; break;
                    case 4: label1.Text = label1.Text + "CD"; break;
                    case 5: label1.Text = label1.Text + "D"; break;
                    case 6: label1.Text = label1.Text + "DC"; break;
                    case 7: label1.Text = label1.Text + "DCC"; break;
                    case 8: label1.Text = label1.Text + "DCCC"; break;
                    case 9: label1.Text = label1.Text + "CM"; break;

                        
                }
                switch (onlar)
                {
                    case 1: label1.Text = label1.Text + "X"; break;
                    case 2: label1.Text = label1.Text + "XX"; break;
                    case 3: label1.Text = label1.Text + "XXX"; break;
                    case 4: label1.Text = label1.Text + "XL"; break;
                    case 5: label1.Text = label1.Text + "L"; break;
                    case 6: label1.Text = label1.Text + "LX"; break;
                    case 7: label1.Text = label1.Text + "LXX"; break;
                    case 8: label1.Text = label1.Text + "LXXX"; break;
                    case 9: label1.Text = label1.Text + "XC"; break;

                }
                switch (birler)
                {
                    case 1: label1.Text = label1.Text + "I"; break;
                    case 2: label1.Text = label1.Text + "II"; break;
                    case 3: label1.Text = label1.Text + "III"; break;
                    case 4: label1.Text = label1.Text + "IV"; break;
                    case 5: label1.Text = label1.Text + "V"; break;
                    case 6: label1.Text = label1.Text + "VI"; break;
                    case 7: label1.Text = label1.Text + "VII"; break;
                    case 8: label1.Text = label1.Text + "VIII"; break;
                    case 9: label1.Text = label1.Text + "IX"; break;


                }
            }
            else
            {
                MessageBox.Show("ABİM YANLIŞ DEĞER GİRDİN(1-4000 GİRİLEBİLİR.)");
            }


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            String rakam = textBox2.Text.ToUpper();  //Küçük harfleri kabul etmesi için.

            int sayi = 0, a1 = 0, a2 = 0, a3 = 0;
            for (int i = 0; i < rakam.Length; i++)
            {
                a2 = a1;
                switch (rakam[i])
                {
                    case 'I':
                        a1 = 1;
                        break;
                    case 'V':
                        a1 = 5;
                        break;
                    case 'X':
                        a1 = 10;
                        break;
                    case 'L':
                        a1 = 50;
                        break;
                    case 'C':
                        a1 = 100;
                        break;
                    case 'D':
                        a1 = 500;
                        break;
                    case 'M':
                        a1 = 1000;
                        break;
                    default: MessageBox.Show("ABİM HATA YAPTIN");
                        i = 100;   //Döngüden çıkmak için.
                        break;
                        

                }
               
                if (a1 > a2)
                {
                    a3 = -2 * a2;
                }
                else
                {
                    a3 = 0;
                }
                sayi += a1+a3;

                if (sayi<4000)
                {
                    label2.Text = sayi.ToString();
                    textBox2.Clear();

                }
                else
                {
                    label2.Text = "";
                    MessageBox.Show("ABİM 4000'DEN YUKARISI KURTARMAZ");
                    break;
                }
            }
            
            
        
            
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
    
}  //kaynaklar
   //https://www.bilisimkonulari.com/c-roma-rakamini-sayiya-ceviren-program.html
   //http://www.gorselprogramlama.com/klavyeden-girilen-bir-sayiyi-roma-rakamina-ceviren-program-c-console/
   //http://www.gorselprogramlama.com/yaziyi-string%E2%80%99i-buyuk-veya-kucuk-harfe-cevirme-c-net-ders-31/
   //https://sanalkurs.net/c-ile-degiskenleri-convert-islemleri-4782.html

   //Oğuzhan Dincar-2017280073


