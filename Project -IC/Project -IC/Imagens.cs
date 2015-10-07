using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project__IC
{
    public partial class Imagens : Form
    {
        public Imagens()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Imagem 1")
            {
                pictureBox1.Load("Radiação Ionizante 1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                label1.Text = "Representação do poder de penetração de certas radiações";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
