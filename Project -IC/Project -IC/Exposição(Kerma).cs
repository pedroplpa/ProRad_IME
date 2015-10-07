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
    public partial class Exposição_Kerma_ : Form
    {
        public Exposição_Kerma_()
        {
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com o kerma de colisão do ar em J kg^-1");
        }

        // Variáveis e Constantes
        float kermaColisaoAr;
        const float constante = 33.97f;

        //Clique em OK
        private void button1_Click(object sender, EventArgs e)
        {
            //Recebe o que foi inserido pelo usuário em formato texto e transforma em número
            kermaColisaoAr = float.Parse(textBox_x.Text);
            
            //Cálculo do resultado e impressão na tela
            result.Text = (kermaColisaoAr / constante).ToString() + " C kg^-1";
        }

        //Clique em Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha a janela caso se escolha o cancelar
            this.Close();
        }
    }
}
