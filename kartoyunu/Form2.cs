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
    public partial class Form2 : Form
    {
        
        int puan = 0;
        int time = 60;

        Image[] resimler = {

            Properties.Resources._11,
            Properties.Resources._10,
            Properties.Resources._2,
            Properties.Resources._21,
            Properties.Resources._41,

        };

        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4};

        PictureBox ilkkutu;
        int ilkIndeks;
        int bulunan;
        public static string gonderilicekveri;
              
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            resimleriKaristir();
            
        }
       
        private void resimleriKaristir()
        {
            Random rnd = new Random();

           for(int i=0; i < 10; i++)
            {
                int sayi = rnd.Next(10);
                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            //click sesi
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\naz\Desktop\clicksound.wav");
            splayer.Play() ;

            PictureBox kutu = (PictureBox) sender;
            
            int kutuNo = int.Parse(kutu.Name.Substring(10));
            int indeksNo = indeksler[kutuNo-1];
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
                    
                   
                    if (bulunan == 5)
                    {
                        timer1.Stop();
                       
                        //uyarı ekranı
                        MessageBox2 m2 = new MessageBox2();
                        m2.Show();
                        this.Close();

                        bulunan = 0;
                        foreach(Control kontrol in Controls)
                        {
                            kontrol.Visible = true;
                        }

                        resimleriKaristir();
                    }
                    
                }
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
       
        private void button2_Click(object sender, EventArgs e)
        {
          
          
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
                MessageBox1 mt = new MessageBox1();
                mt.Show();
                this.Close();

                /*
                 timer1.Stop();
                 bulunan = 0;
                 time = 60;
                 puan = 0;
                 label4.Text = puan.ToString();
                 timer1.Start();
                 foreach (Control kontrol in Controls)
                 {
                     kontrol.Visible = true;
                 }

                 resimleriKaristir();
                */
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
