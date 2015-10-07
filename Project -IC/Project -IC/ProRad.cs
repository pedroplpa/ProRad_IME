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
    public partial class ProRad : Form
    {
        public ProRad()
        {
            InitializeComponent();
        }

        //Rotinas de cliques nas abas
        private void energiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela que calcula a energia
            Energia energia = new Energia();
            energia.Show();
        }

        private void fluênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela que calcula a fluência
            Fluência fluencia = new Fluência();
            fluencia.Show();
        }

        private void taxaDeFluênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela que calcula a taxa de fluência
            Taxa_de_Fluência taxaFluencia = new Taxa_de_Fluência();
            taxaFluencia.Show();
        }

        private void fluênciaEmEnergiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela que calcula a fluência em energia
            Fluência_em_Energia fluenciaEnergia = new Fluência_em_Energia();
            fluenciaEnergia.Show();
        }

        private void taxaDeFluênciaEmEnergiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela que calcula a taxa de fluência em energia
            Taxa_de_Fluência_em_Energia taxaFluenciaEnergia = new Taxa_de_Fluência_em_Energia();
            taxaFluenciaEnergia.Show();
        }

        private void kermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela que calcula o kerma
            Kerma kerma = new Kerma();
            kerma.Show();
        }

        private void ajudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de ajuda
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }

        private void imagensRealcionadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Imagem
            Imagens imagens = new Imagens();
            imagens.Show();
        }

        private void vídeosRelacionadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Vídeos
            Videos videos = new Videos();
            videos.Show();
        }

        private void kermaColisaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Kerma de Colisão
            KermaColisão kermaColisao = new KermaColisão();
            kermaColisao.Show();
        }

        private void taxadekermaToolStripMenu_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Taxa de Kerma
            Taxa_de_Kerma taxaKerma = new Taxa_de_Kerma();
            taxaKerma.Show();
        }

        private void doseAbsorvidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Dose Absorvida
            Dose_Absorvida dose = new Dose_Absorvida();
            dose.Show();
        }

        private void taxaDoseAbsorvidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Taxa Dose Absorvida
            Taxa_Dose_Absorvida taxaDose = new Taxa_Dose_Absorvida();
            taxaDose.Show();
        }

        private void exposiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Taxa Dose Absorvida
            Exposição exposicao = new Exposição();
            exposicao.Show();
        }

        private void relaçãoDeExposiçãoEFluênciaEmEnergiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Relação de Exposição e Fluência em Energia
            Exposição_Kerma_ exposicao2 = new Exposição_Kerma_();
            exposicao2.Show();
        }

        private void taxaDeExposiçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Taxa de Exposição
            Taxa_Exposição taxaExposicao = new Taxa_Exposição();
            taxaExposicao.Show();
        }

        private void doseEquivalenteToolStripMenu_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Dose Equivalente
            Dose_Equivalente doseEquivalente = new Dose_Equivalente();
            doseEquivalente.Show();
        }

        private void atenuaçãoExponencialSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Atenuação Exponencial Simples
            Atenuação_Exponencial_Simples atenExpSimples = new Atenuação_Exponencial_Simples();
            atenExpSimples.Show();
        }

        private void atenuaçãoExponencialCompostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Atenuação Exponencial Composta
            Atenuação_Exponencial_Composta atenExpComposta = new Atenuação_Exponencial_Composta();
            atenExpComposta.Show();
        }

        private void equilíbrioDeRadiaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Equilíbrio de Radiação
            Equilíbrio_de_Radiação equiRadiacao = new Equilíbrio_de_Radiação();
            equiRadiacao.Show();
        }

        private void equilíbrioDePartículaCarregadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Equilíbrio da Partícula Carregada
            Equilíbrio_da_Partícula_Carregada equiPartCarregada = new Equilíbrio_da_Partícula_Carregada();
            equiPartCarregada.Show();
        }

        private void doseAbsorvidaXexposicao_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Relação de Dose Absorvida e Exposição
            Dose_Absorvida_e_Exposição doseXexpo = new Dose_Absorvida_e_Exposição();
            doseXexpo.Show();
        }

        private void partículasPesadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria e mostra na tela a janela de Relação de Dose Absorvida e Exposição
            Poder_de_Parada___Partículas_Pesadas partPesada = new Poder_de_Parada___Partículas_Pesadas();
            partPesada.Show();
        }

     }
}
