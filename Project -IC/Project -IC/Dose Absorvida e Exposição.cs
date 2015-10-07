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
    public partial class Dose_Absorvida_e_Exposição : Form
    {
        public Dose_Absorvida_e_Exposição()
        {
            //Inicializa
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com a exposição em C/kg");
        }

        // Constantes
        const float coef = 33.97f;

        //Variáveis
        float expo;

        //Clique no botão OK
        private void button1_Click(object sender, EventArgs e)
        {
            expo = float.Parse(textBox_x.Text);
            result.Text = (coef * expo).ToString() + " J / kg";
        }

        //Clique no botão Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
