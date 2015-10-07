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
    public partial class Energia : Form
    {
        public Energia()
        {
            //Inicializa
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com o comprimento da onda em mm");
        }
        
        // Constantes
        double Hj = 6.626 * Math.Pow(10, -34);
        double HkeV = 4.136 * Math.Pow(10, -18);
        double C = 2.998 * Math.Pow(10, 8);

        // Variáveis
        string strLamb;
        float lamb;
        double resultado;

        //Clique no botão OK
        private void button1_Click(object sender, EventArgs e)
        {
            //Recebe o dado inserido como texto
            strLamb = textBox_x.Text;
            
            //Transforma o texto em número
            if (strLamb == "")
            {
                lamb = 0;
            }
            
            else
            {
                lamb = float.Parse(strLamb);
            }
            
            //Escolhe uma das opções de cálculo com base no escolhido pelo usuário
            if (radioButton1.Checked)
            {
                resultado = Hj * C / (lamb * Math.Pow(10, -9));
                result.Text = resultado.ToString() + " J";    
            }
            
            else if (radioButton2.Checked)
            {
                resultado = HkeV * C / (lamb * Math.Pow(10, -9));
                result.Text = resultado.ToString() + " keV";
            } 
        }
        
        //Clique no botão cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha a janela caso se escolha o cancelar
            this.Close();
        }
    }
}
