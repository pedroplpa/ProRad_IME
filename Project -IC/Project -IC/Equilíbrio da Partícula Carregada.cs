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
    public partial class Equilíbrio_da_Partícula_Carregada : Form
    {
        public Equilíbrio_da_Partícula_Carregada()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        //Clicar no botão OK
        private void button1_Click(object sender, EventArgs e)
        {
            KermaColisão kerColisao = new KermaColisão();
            kerColisao.Show();
        }

        //Clicar no botão Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
