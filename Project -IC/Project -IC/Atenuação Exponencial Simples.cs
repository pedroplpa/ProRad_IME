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
    public partial class Atenuação_Exponencial_Simples : Form
    {
        public Atenuação_Exponencial_Simples()
        {
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com o número inicial de partículas");

            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(textBox_y, "Preencha com a expessura do material em m");

            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(textBox_y, "Preencha com o coeficiente de atenuação linear  m^-1");
        }

        // Variáveis
        float numPart, expessura, coef;

        //Clique em OK
        private void button1_Click(object sender, EventArgs e)
        {
            //Recebe o que foi inserido pelo usuário em formato texto e transforma em número
            numPart = float.Parse(textBox_x.Text);
            expessura = float.Parse(textBox_y.Text);
            coef = float.Parse(textBox_z.Text);

            //Cálculo do resultado e impressão na tela
            result.Text = (numPart * (float)Math.Exp(-1*coef*expessura)).ToString();
        }

        //Clique em Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha a janela caso se escolha o cancelar
            this.Close();
        }
    }
}
