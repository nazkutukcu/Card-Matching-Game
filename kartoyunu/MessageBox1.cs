using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartoyunu
{
    public partial class MessageBox1 : Form
    {
        public MessageBox1()
        {
            InitializeComponent();
        }
        private void MessageBox1_Load(object sender, EventArgs e)
        {
            label2.Text = Form2.gonderilicekveri;
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
