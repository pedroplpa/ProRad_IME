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
    public partial class Dose_Absorvida : Form
    {
        public Dose_Absorvida()
        {
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com a energia remanescente em J");

            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(textBox_y, "Preencha com a massa analisada em kg");
        }

        // Variáveis
        float energia, massa;

        //Clique em OK
        private void button1_Click(object sender, EventArgs e)
        {
            //Recebe o que foi inserido pelo usuário em formato texto e transforma em número
            energia = float.Parse(textBox_x.Text);
            massa = float.Parse(textBox_y.Text);

            //Cálculo do resultado e impressão na tela
            result.Text = (energia / massa).ToString() + " J kg^-1";
        }

        //Clique em Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha a janela caso se escolha o cancelar
            this.Close();
        }
    }
}
