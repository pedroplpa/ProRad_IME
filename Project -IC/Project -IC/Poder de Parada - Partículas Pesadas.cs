using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project__IC
{
    public partial class Poder_de_Parada___Partículas_Pesadas : Form
    {
        public Poder_de_Parada___Partículas_Pesadas()
        {
            InitializeComponent();
        }

        private void Poder_de_Parada___Partículas_Pesadas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proRadDataSet.PotencialExcitação' table. You can move, or remove it, as needed.
            this.potencialExcitaçãoTableAdapter.Fill(this.proRadDataSet.PotencialExcitação);

        }

        //Constantes
        float luz = 3 *(float)Math.Pow(10,8);

        //Variáveis
        float numAtomMeioPot;
        float carga;
        float massaMeioAbsorvedor;
        float velocidade;
        float potExcitacao;

        private void button1_Click(object sender, EventArgs e)
        {
            numAtomMeioPot = float.Parse(textBox1.Text);
            carga = float.Parse(textBox2.Text);
            massaMeioAbsorvedor = float.Parse(textBox3.Text);
            velocidade = float.Parse(textBox4.Text);

            potExcitacao = 0.000001f * float.Parse(comboBox2.SelectedValue.ToString());


            float beta = velocidade / luz;
            float result = 0.3071f * ( numAtomMeioPot * carga * carga / (massaMeioAbsorvedor * beta * beta)) * (13.8373f + (float)Math.Log((beta * beta / (1 - beta * beta))) - beta * beta - (float)Math.Log(potExcitacao));

            resultado.Text = result.ToString() + " Mev . cm² / g";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
