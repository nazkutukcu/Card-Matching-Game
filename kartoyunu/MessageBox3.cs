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
    public partial class MessageBox3 : Form
    {
        public MessageBox3()
        {
            InitializeComponent();
        }

        private void MessageBox3_Load(object sender, EventArgs e)
        {
            label2.Text = Form5.gonderilicekveri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
