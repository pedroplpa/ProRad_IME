﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project__IC
{
    public partial class Taxa_Dose_Absorvida : Form
    {
        public Taxa_Dose_Absorvida()
        {
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox_x, "Preencha com a dose absorvida em J kg^-1");

            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(textBox_y, "Preencha com o tempo que leva para a\nradiação ser absorvida pela massa");
        }
       
        // Variáveis
        float doseAbsorvida, tempo;

        //Clique no botão OK
        private void button1_Click(object sender, EventArgs e)
        {
            //Recebe o que foi inserido pelo usuário em formato texto e transforma em número
            doseAbsorvida = float.Parse(textBox_x.Text);
            tempo = float.Parse(textBox_y.Text);

            //Cálculo do resultado e impressão na tela
            result.Text = (doseAbsorvida / tempo).ToString() + " J kg^-1 s^-1";
        }
        
        //Clique no botão cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fecha a janela caso se escolha o cancelar
            this.Close();
        }
    }
}
