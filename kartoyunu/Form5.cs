using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace kartoyunu
{
    public partial class Form5 : Form
    {
       
        Image[] resimler = {

            Properties.Resources.ç1,
            Properties.Resources.ç2,
            Properties.Resources.ç3,
            Properties.Resources.ç4,
            Properties.Resources.ç5,
            Properties.Resources.ç6,
            Properties.Resources.ç7,
            Properties.Resources.ç8,
            Properties.Resources.ç9,
        };

        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4,5,5,6,6,7,7,8,8 };

        PictureBox ilkkutu;
        int ilkIndeks;
        int bulunan;
        public static string gonderilicekveri;
        int puan = 0;
        int time = 100;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
            resimleriKaristir();
           
        }

        private void resimleriKaristir()
        {
          
            Random rnd = new Random();

            for (int i = 0; i < 18; i++)
            {
                int sayi = rnd.Next(18);
                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //click sesi
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\naz\Desktop\clicksound.wav");
            splayer.Play();

            PictureBox kutu = (PictureBox)sender;

            int kutuNo = int.Parse(kutu.Name.Substring(10));
            int indeksNo = indeksler[kutuNo - 1];
            kutu.Image = resimler[indeksNo];
            kutu.Refresh();


            if (ilkkutu == null)
            {
                ilkkutu = kutu;
                ilkIndeks = indeksNo;
                ilkkutu.Enabled = false;

            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                label5.Text = "Bu bir çift değil";

                ilkkutu.Image = null;
                kutu.Image = null;
                kutu.Enabled = false;

                if (ilkIndeks == indeksNo)
                {
                    kutu.Enabled = false;
                    //doğru cevap sesi
                    SoundPlayer player = new SoundPlayer(@"C:\Users\naz\Desktop\correctsound.wav");
                    player.Play();

                    label5.Text = "Bir çift buldun!";
                    bulunan++;
                    puan += 5;
                    label4.Text = puan.ToString();
                    ilkkutu.Visible = false;
                    kutu.Visible = false;

                    if (bulunan == 9)
                    {
                        timer1.Stop();

                        //uyarı ekranı
                        MessageBox2 m2 = new MessageBox2();
                        m2.Show();
                        this.Close();

                        bulunan = 0;
                        foreach (Control kontrol in Controls)
                        {
                            kontrol.Visible = true;
                        }
                        resimleriKaristir();
                       
                    }
                }
                //yanlış cevap sesi
                else
                {
                    SoundPlayer player = new SoundPlayer(@"C:\Users\naz\Downloads\frog.wav");
                    player.Play();
                    ilkkutu.Enabled = true;
                    kutu.Enabled = true;
                }
                ilkkutu = null;              
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time -= 1;
            label1.Text = time.ToString();

            if (label1.Text=="0")
            {
                timer1.Stop();
                //uyarı ekranı
                gonderilicekveri = label4.Text;
                MessageBox3 mb = new MessageBox3();
                mb.Show();
                this.Close();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

      
    }
}
