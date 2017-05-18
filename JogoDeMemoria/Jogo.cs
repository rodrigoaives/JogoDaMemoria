using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDeMemoria
{
    public partial class Jogo : Form
    {
        int pontuacao = 0, contadorCliques = 0;
        private SoundPlayer moedinhaSound;
        


        public Jogo()
        {
            InitializeComponent();
            moedinhaSound = new SoundPlayer("moedinha.wav");             
        }

        private void btnLuigi1_Click(object sender, EventArgs e)
        {
            luigi1.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            timerLuigi.Start();
        }

        private void btnBonito1_Click(object sender, EventArgs e)
        {
            bonito1.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques); 
            timerBonito.Start();
        }
        private void btnBonito2_Click(object sender, EventArgs e)
        {
            bonito2.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            if (timerBonito.Enabled == false)
            {
                timerBonito.Start();
            }
        }

        private void btnBowser1_Click(object sender, EventArgs e)
        {
            bowser1.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            timerBowser.Start();

        }

        private void btnBowser2_Click(object sender, EventArgs e)
        {
            bowser2.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            if (timerBowser.Enabled == false)
            {
                timerBowser.Start();
            }
        }

        private void btnCogu1_Click(object sender, EventArgs e)
        {
            cogu1.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            timerCogu.Start();
        }

        private void btnCogu2_Click(object sender, EventArgs e)
        {
            cogu2.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            if (timerCogu.Enabled == false)
            {
                timerCogu.Start();
            }
        }

        private void btnLuigi2_Click(object sender, EventArgs e)
        {
            luigi2.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            if (timerLuigi.Enabled == false)
            {
                timerLuigi.Start();
            }
        }

        private void btnWario1_Click(object sender, EventArgs e)
        {
            wario1.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            timerWario.Start();
        }

        private void btnWario2_Click(object sender, EventArgs e)
        {
            wario2.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            if (timerWario.Enabled == false)
            {
                timerWario.Start();
            }
        }

        private void btnMario1_Click(object sender, EventArgs e)
        {
            mario1.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            timerMario.Start();
        }

        private void btnMario2_Click(object sender, EventArgs e)
        {
            mario2.Visible = true;
            moedinha.Visible = false;
            contadorCliques += 1;
            exibeCliques.Text = Convert.ToString(contadorCliques);
            if (timerMario.Enabled == false)
            {
                timerMario.Start();
            }
        }            
       

        private void timerBonito_Tick(object sender, EventArgs e)
        {
            timerBonito.Stop();

            if (bonito1.Visible == true && bonito2.Visible == true)
            {
                pontuacao += 10;
                exibePontuacao.Text = Convert.ToString(pontuacao);
                moedinha.Visible = true;
                moedinhaSound.Play();
            }
            else if (bonito1.Visible == false || bonito2.Visible == false)
            {
                bonito1.Visible = false;
                bonito2.Visible = false;
            }

            if (bonito1.Visible == true && bonito2.Visible == true &&
                bowser1.Visible == true && bowser2.Visible == true &&
                cogu1.Visible == true && cogu2.Visible == true &&
                luigi1.Visible == true && luigi2.Visible == true &&
                mario1.Visible == true && mario2.Visible == true &&
                wario1.Visible == true && wario2.Visible == true)
            {
                Hide();
                TelaGanhou telaGanhou = new TelaGanhou();
                telaGanhou.ShowDialog();
            }
        }            

        
        private void timerBowser_Tick(object sender, EventArgs e)
        {
            timerBowser.Stop();

            if (bowser1.Visible == true && bowser2.Visible == true)
            {
                pontuacao += 10;
                exibePontuacao.Text = Convert.ToString(pontuacao);
                moedinha.Visible = true;
                moedinhaSound.Play();
            }
            else if (bowser1.Visible == false || bowser2.Visible == false)
            {
                bowser1.Visible = false;
                bowser2.Visible = false;
            }

            if (bonito1.Visible == true && bonito2.Visible == true &&
                bowser1.Visible == true && bowser2.Visible == true &&
                cogu1.Visible == true && cogu2.Visible == true &&
                luigi1.Visible == true && luigi2.Visible == true &&
                mario1.Visible == true && mario2.Visible == true &&
                wario1.Visible == true && wario2.Visible == true)
            {
                Hide();
                TelaGanhou telaGanhou = new TelaGanhou();
                telaGanhou.ShowDialog();
            }

        }

        private void timerCogu_Tick(object sender, EventArgs e)
        {
            timerCogu.Stop();

            if (cogu1.Visible == true && cogu2.Visible == true)
            {
                pontuacao += 10;
                exibePontuacao.Text = Convert.ToString(pontuacao);
                moedinha.Visible = true;
                moedinhaSound.Play();
            }
            else if (cogu1.Visible == false || cogu2.Visible == false)
            {
                cogu1.Visible = false;
                cogu2.Visible = false;
            }

            if (bonito1.Visible == true && bonito2.Visible == true &&
                bowser1.Visible == true && bowser2.Visible == true &&
                cogu1.Visible == true && cogu2.Visible == true &&
                luigi1.Visible == true && luigi2.Visible == true &&
                mario1.Visible == true && mario2.Visible == true &&
                wario1.Visible == true && wario2.Visible == true)
            {
                Hide();
                TelaGanhou telaGanhou = new TelaGanhou();
                telaGanhou.ShowDialog();
            }
        }

        private void timerLuigi_Tick(object sender, EventArgs e)
        {
            timerLuigi.Stop();

            if (luigi1.Visible == true && luigi2.Visible == true)
            {
                pontuacao += 10;
                exibePontuacao.Text = Convert.ToString(pontuacao);
                moedinha.Visible = true;
                moedinhaSound.Play();
            }
            else if (luigi1.Visible == false || luigi2.Visible == false)
            {
                luigi1.Visible = false;
                luigi2.Visible = false;
            }

            if (bonito1.Visible == true && bonito2.Visible == true &&
                bowser1.Visible == true && bowser2.Visible == true &&
                cogu1.Visible == true && cogu2.Visible == true &&
                luigi1.Visible == true && luigi2.Visible == true &&
                mario1.Visible == true && mario2.Visible == true &&
                wario1.Visible == true && wario2.Visible == true)
            {
                Hide();
                TelaGanhou telaGanhou = new TelaGanhou();
                telaGanhou.ShowDialog();
            }
        }

        private void timerMario_Tick(object sender, EventArgs e)
        {
            timerMario.Stop();

            if (mario1.Visible == true && mario2.Visible == true)
            {
                pontuacao += 10;
                exibePontuacao.Text = Convert.ToString(pontuacao);
                moedinha.Visible = true;
                moedinhaSound.Play();
            }
            else if (mario1.Visible == false || mario2.Visible == false)
            {
                mario1.Visible = false;
                mario2.Visible = false;
            }

            if (bonito1.Visible == true && bonito2.Visible == true &&
                bowser1.Visible == true && bowser2.Visible == true &&
                cogu1.Visible == true && cogu2.Visible == true &&
                luigi1.Visible == true && luigi2.Visible == true &&
                mario1.Visible == true && mario2.Visible == true &&
                wario1.Visible == true && wario2.Visible == true)
            {
                Hide();
                TelaGanhou telaGanhou = new TelaGanhou();
                telaGanhou.ShowDialog();
            }
        }

        private void timerWario_Tick(object sender, EventArgs e)
        {
            timerWario.Stop();

            if (wario1.Visible == true && wario2.Visible == true)
            {
                pontuacao += 10;
                exibePontuacao.Text = Convert.ToString(pontuacao);
                moedinha.Visible = true;
                moedinhaSound.Play();
            }
            else if (wario1.Visible == false || wario2.Visible == false)
            {
                wario1.Visible = false;
                wario2.Visible = false;
            }

            if (bonito1.Visible == true && bonito2.Visible == true &&
                bowser1.Visible == true && bowser2.Visible == true &&
                cogu1.Visible == true && cogu2.Visible == true &&
                luigi1.Visible == true && luigi2.Visible == true &&
                mario1.Visible == true && mario2.Visible == true &&
                wario1.Visible == true && wario2.Visible == true)
            {
                Hide();
                TelaGanhou telaGanhou = new TelaGanhou();
                telaGanhou.ShowDialog();
            }
        } 
    }
}
