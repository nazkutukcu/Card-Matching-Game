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
    public partial class MessageBox4 : Form
    {
        public MessageBox4()
        {
            InitializeComponent();
        }
        private void MessageBox4_Load(object sender, EventArgs e)
        {
            label2.Text = Form6.gonderilicekveri;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
