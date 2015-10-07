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
    public partial class Fluência_em_Energia : Form
    {
        public Fluência_em_Energia()
        {
            //Inicializa
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com o número de partículas");

            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(textBox_y, "Preencha com a energia de cada partícula em J");

            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(textBox_z, "Preencha com a área atravessada pela radiação em m²");
        }

        // Variáveis
        float numParticulas, area, energia;

        //Clique no botão OK
        private void button1_Click(object sender, EventArgs e)
        {
            //Recebe o que foi inserido pelo usuário em formato texto e transforma em número
            numParticulas = float.Parse(textBox_x.Text);
            energia = float.Parse(textBox_y.Text);
            area = float.Parse(textBox_z.Text);
            
            //Cálculo do resultado e impressão na tela
            result.Text = (numParticulas * energia / area).ToString() + " J/m²";
        }

        //Clique no botão cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha a janela caso se escolha o cancelar
            this.Close();
        }
    }
}
