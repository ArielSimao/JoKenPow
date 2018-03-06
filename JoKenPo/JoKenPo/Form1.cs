using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {

        enum Opcoes { Pedra, Papel, Tesoura };
        enum Resultado { Jogador, Computador, Empate};
        Resultado ganhador = new Resultado();
        Opcoes jogador = new Opcoes();
        Opcoes computador = new Opcoes();
        Random rdm = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void botaoPedra_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Pedra;
            EscolhaJogador();
            EscolhaComputador();
            verificarGanhador();
        }

        private void botaoPapel_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Papel;
            EscolhaJogador();
            EscolhaComputador();
            verificarGanhador();
        }

        private void botaoTesoura_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Tesoura;
            EscolhaJogador();
            EscolhaComputador();
            verificarGanhador();
        }

        void EscolhaJogador()
        {
            switch (jogador)
            {
                case Opcoes.Pedra:
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("C:/Users/Ariel/Desktop/JoKenPo/Pedra.jpg");
                    break;
                case Opcoes.Papel:
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("C:/Users/Ariel/Desktop/JoKenPo/Papel.jpg");
                    break;
                case Opcoes.Tesoura:
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("C:/Users/Ariel/Desktop/JoKenPo/Tesoura.jpg");
                    break;
            }
        }

        void EscolhaComputador()
        {
            int num = rdm.Next(1, 4);

            if (num == 1)
            {
                computador = Opcoes.Pedra; 
                imgEscolhaComputado.BackgroundImage = Image.FromFile("C:/Users/Ariel/Desktop/JoKenPo/Pedra.jpg");
            }
            else if ( num == 2)
            {
                computador = Opcoes.Papel;
                imgEscolhaComputado.BackgroundImage = Image.FromFile("C:/Users/Ariel/Desktop/JoKenPo/Papel.jpg");
            }
            else if (num == 3)
            {
                computador = Opcoes.Tesoura;
                imgEscolhaComputado.BackgroundImage = Image.FromFile("C:/Users/Ariel/Desktop/JoKenPo/Tesoura.jpg");
            }
        }

        void verificarGanhador()
        {
            switch (jogador)
            {
                case Opcoes.Pedra:
                    if (computador == Opcoes.Pedra)
                        ganhador = Resultado.Empate;
                    else if (computador == Opcoes.Papel)
                        ganhador = Resultado.Computador;
                    else if (computador == Opcoes.Tesoura)
                        ganhador = Resultado.Jogador;
                    break;

                case Opcoes.Papel:
                    if (computador == Opcoes.Pedra)
                        ganhador = Resultado.Jogador;
                    else if (computador == Opcoes.Papel)
                        ganhador = Resultado.Empate;
                    else if (computador == Opcoes.Tesoura)
                        ganhador = Resultado.Computador;
                    break;

                case Opcoes.Tesoura:
                    if (computador == Opcoes.Pedra)
                        ganhador = Resultado.Computador;
                    else if (computador == Opcoes.Papel)
                        ganhador = Resultado.Jogador;
                    else if (computador == Opcoes.Tesoura)
                        ganhador = Resultado.Empate;
                    break;
            }

            if (ganhador == Resultado.Jogador)
            {
                grupoPlacar.BackColor = Color.LawnGreen;
                placarJogador.Text = (int.Parse(placarJogador.Text) + 1).ToString();
            }
            else if (ganhador == Resultado.Computador)
            {
                grupoPlacar.BackColor = Color.Red;
                placarComputador.Text = (int.Parse(placarComputador.Text) + 1).ToString();
            }
            else
            {
                grupoPlacar.BackColor = Color.Blue;
            }
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
