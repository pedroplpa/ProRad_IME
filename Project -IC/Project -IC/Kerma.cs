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
    public partial class Kerma : Form
    {
        public Kerma()
        {
            //Inicializa
            InitializeComponent();
            //Escolhe o botão OK para ser o botão previamente selecionado
            this.AcceptButton = button1;

            //Define as abas de ajuda para cada um dos elementos de preenchimento
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox1, "Preencha com a fluência em energia em J/m²");

            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(comboBox1, "Escolha a energia do fóton, em MeV, da radiação\nincidente clicando na seta");

            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(comboBox2, "Escolha o material pelo qual a radiação irá atravessar\nclicando na seta");
        }
       
        private void Kerma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proRadDataSet.ConstanteKerma' table. You can move, or remove it, as needed.
            this.constanteKermaTableAdapter.Fill(this.proRadDataSet.ConstanteKerma);
            // TODO: This line of code loads data into the 'proRadDataSet.ConstanteKerma' table. You can move, or remove it, as needed.
            this.constanteKermaTableAdapter.Fill(this.proRadDataSet.ConstanteKerma);

        }

        //Clique no botão OK
        private void button1_Click(object sender, EventArgs e)
        {
            //Recebe o que foi inserido pelo usuário em formato texto e transforma em número
            string text = textBox1.Text != "" ? textBox1.Text : "0";
            float fluencia = float.Parse(text);

            //Recebe o que foi inserido pelo usuário em formato texto
            string material = comboBox2.SelectedValue.ToString();
            string energia = comboBox1.SelectedItem.ToString();

            //Define-se a string de conexão do banco de dados necessária ao acesso dos dados da tabela
            string strConn = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=ProRad;Integrated Security=True";
            
            //Utilizando a conexão SQL
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                //Abre-se a conexão e permite-se o uso dos dados das tabelas
                conn.Open();

                //Utilizando um comando SQL para acessar e selecionar os dados necessários da tabela
                using (SqlCommand com = new SqlCommand("SELECT [" + energia + "] FROM ConstanteKerma WHERE Material = '" + material + "'", conn))
                {
                    //Realiza-se a leitura dos dados da tabela de acordo com as restrições passadas pelo comando SQL
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        //Recebe-se o valor mostrado na tabela e passa-o para uma variável
                        float num = (float)reader.GetDouble(0); // Um valor float para SQL representa um valor double para C#

                        //Cálculo do resultado e impressão na tela
                        result.Text = (num * fluencia).ToString();
                    }
                }
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
