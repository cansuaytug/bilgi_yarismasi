using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace bilgicns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            lbldogru.Visible = false;
        }

        
        int sayac = 0;
        int dogrusayisi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.Pink;
            buttonb.BackColor = Color.Pink;
            buttonc.BackColor = Color.Pink;
            buttond.BackColor = Color.Pink;
            buttonbas.Enabled = false;
            buttonA.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttonbas.Text = "Sonraki";
            sayac++;
            if (sayac == 1)
            {
                textBox1.Text = "Mustafa Kemal Atatürk kaç yıl yaşamıştır?";
                buttonA.Text = "55";
                buttonb.Text = "54";
                buttonc.Text = "57";
                buttond.Text = "61";
                lbldogru.Text = "57";
                
            }
         
            if (sayac==2)
            {
                textBox1.Text = "Kuzular ne ses çıkarır?";
                buttonA.Text = "Ai";
                buttonb.Text = "Vız";
                buttonc.Text = "Mee";
                buttond.Text = "Mır";
                lbldogru.Text = "Mee";
                

            }
            if(sayac==3)
            {
                textBox1.Text = "Zonguldak'ın en meşhur şeyi nedir?";
                buttonA.Text = "Deniz";
                buttonb.Text = "Kömür";
                buttonc.Text = "Tavuk Dürüm";
                buttond.Text = "Hamur";
                lbldogru.Text = "Kömür";
               
            }
            if(sayac==4)
            {
                textBox1.Text = "Nobel ödülleri hangi ülkede verilmektedir?";
                buttonA.Text = "Amerika";
                buttonb.Text = "İngiltere";
                buttonc.Text = "İsviçre";
                buttond.Text = "İsveç";
                lbldogru.Text = "İsveç";
               
            }
            if (sayac == 5)
            {
                textBox1.Text = "'Ateşkes' anlamına gelen kelime hangisidir?";
                buttonA.Text = "Antlaşma";
                buttonb.Text = "Mütareke";
                buttonc.Text = "Mücahit";
                buttond.Text = "Müşahede";
                lbldogru.Text = "Mütareke";
                
            }
            if (sayac == 6)
            {
                textBox1.Text = "Ro-ro taşımacılığı nasıl yapılır?";
                buttonA.Text = "Demir yoluyla";
                buttonb.Text = "Deniz yoluyla";
                buttonc.Text = "Hava yoluyla";
                buttond.Text = "Kara yoluyla";
                lbldogru.Text = "Deniz yoluyla";
                
            }
            if (sayac == 7)
            {
                textBox1.Text = "'Bukle bukle' ve 'kıvır kıvır' benzetmeleri hangisi için kullanılır?";
                buttonA.Text = "Kaş";
                buttonb.Text = "Saç";
                buttonc.Text = "Sakal";
                buttond.Text = "Bıyık";
                lbldogru.Text = "Saç";
                
            }
            if (sayac == 8)
            {
                textBox1.Text = "Hangisi periyodik tabloda bulunan bir element değildir?";
                buttonA.Text = "Altın";
                buttonb.Text = "Gümüş";
                buttonc.Text = "Helyum";
                buttond.Text = "Gram";
                lbldogru.Text = "Gram";
                
            }
            if (sayac == 9)
            {
                textBox1.Text = "Hollywood tabelası 1923 yılında hangi sektörün tanıtımı için dikilmiştir?";
                buttonA.Text = "Turizm";
                buttonb.Text = "Sinema";
                buttonc.Text = "Emlak";
                buttond.Text = "Sanat";
                lbldogru.Text = "Emlak";
               
            }
            if (sayac == 10)
            {
                textBox1.Text = "Formula 1 ilk yarışını hangi tarihte yapmıştır ?";
                buttonA.Text = "1945";
                buttonb.Text = "1950";
                buttonc.Text = "1955";
                buttond.Text = "1960";
                lbldogru.Text = "1950";
               
            }
            if (sayac == 11)
            {
                textBox1.Text = "1’in türevi kaçtır?";
                buttonA.Text = "1";
                buttonb.Text = "0";
                buttonc.Text = "10";
                buttond.Text = "-1";
                lbldogru.Text = "0";
                
            }
            if (sayac == 12)
            {
                textBox1.Text = "Bu memelilerden hangisi yumurta ile ürer?";
                buttonA.Text = "Balina";
                buttonb.Text = "Ornitorenk";
                buttonc.Text = "Hindistan Fili";
                buttond.Text = "Yarasa";
                lbldogru.Text = "Ornitorenk";
              
            }
            if (sayac == 13)
            {
                textBox1.Text =  "CANSU AYTUĞ" + Environment.NewLine + "170106206007" + Environment.NewLine + "Oyunu Oynadığınız İçin Teşekkürler:)";
                buttonA.Enabled = false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
                buttonA.Text = "DOĞRU:";
                buttonA.BackColor = Color.Green;
                buttonb.Text = dogrusayisi.ToString();
                buttonb.BackColor = Color.Green;
                buttonc.Text = "YANLIŞ";
                buttonc.BackColor = Color.Red;
                buttond.Text = (12 - dogrusayisi).ToString();
                buttond.BackColor = Color.Red;
                buttonbas.Enabled = false;
                buttonbas.Text = "YİNE BEKLERİZ";
                if (dogrusayisi > 6)
                {
                    MessageBox.Show("TEBRİKLER GÜZEL SONUÇ:)");
                }
                if (dogrusayisi <= 6)
                {
                    MessageBox.Show("BİR DAHAKİNE DAHA İYİSİNİ YAP;)");
                }
            }

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonA.Text == lbldogru.Text)
            {
                buttonA.BackColor = Color.Green;
                dogrusayisi++;
            }
            else
            {
                buttonA.BackColor = Color.Red;
                if (buttonb.Text==lbldogru.Text)
                {
                    buttonb.BackColor = Color.Green;
                }
                if(buttonc.Text==lbldogru.Text)
                {
                    buttonc.BackColor = Color.Green;

                }
                if(buttond.Text==lbldogru.Text)
                {
                    buttond.BackColor = Color.Green;
                }
                
            }
            buttonbas.Enabled = true;
            buttonA.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;

        }
        private void buttonb_Click(object sender, EventArgs e)
        {
            if (buttonb.Text == lbldogru.Text)
            {
                buttonb.BackColor = Color.Green;
                dogrusayisi++;
            }
            else
            {
                buttonb.BackColor = Color.Red;
                if (buttonA.Text == lbldogru.Text)
                {
                    buttonA.BackColor = Color.Green;
                }
                if (buttonc.Text == lbldogru.Text)
                {
                    buttonc.BackColor = Color.Green;

                }
                if (buttond.Text == lbldogru.Text)
                {
                    buttond.BackColor = Color.Green;
                }

            }
            buttonbas.Enabled = true;
            buttonA.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            if (buttonc.Text == lbldogru.Text)
            {
                buttonc.BackColor = Color.Green;
                dogrusayisi++;
            }
            else
            {
                buttonc.BackColor = Color.Red;
                if (buttonb.Text == lbldogru.Text)
                {
                    buttonb.BackColor = Color.Green;
                }
                if (buttonA.Text == lbldogru.Text)
                {
                    buttonA.BackColor = Color.Green;

                }
                if (buttond.Text == lbldogru.Text)
                {
                    buttond.BackColor = Color.Green;
                }

            }
            buttonbas.Enabled = true;
            buttonA.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            if (buttond.Text == lbldogru.Text)
            {
                buttond.BackColor = Color.Green;
                dogrusayisi++;
            }
            else
            {
                buttond.BackColor = Color.Red;
                if (buttonb.Text == lbldogru.Text)
                {
                    buttonb.BackColor = Color.Green;
                }
                if (buttonc.Text == lbldogru.Text)
                {
                    buttonc.BackColor = Color.Green;

                }
                if (buttonA.Text == lbldogru.Text)
                {
                    buttonA.BackColor = Color.Green;
                }

            }
            buttonbas.Enabled = true;
            buttonA.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
        }
    }
}

