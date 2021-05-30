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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.start_hover;
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.exit_hover;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.start_normal;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.exit_normal;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
