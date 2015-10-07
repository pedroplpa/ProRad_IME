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
    public partial class Equilíbrio_de_Radiação : Form
    {
        public Equilíbrio_de_Radiação()
        {
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com a quantidade de matéria transformada em radiação");
        }

        // Variáveis
        float coef = 0;

        //Clique em Adicionar
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Adiciona ao somatório dos coeficientes o que foi digitado em coeficiente de atenuação linear
            coef += float.Parse(textBox_x.Text);
            somaCoef.Text = coef.ToString() + "  J";
        }

        //Clique em Cancelar
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Fecha a janela caso se escolha o cancelar
            this.Close();
        }
    }
}
