/*
 * Written by: Felipe C. Gomes
 * Creation date: 25/02/2023
 * Purpose: Jogo da Velha criado em C# utilizando o Windows Forms como interface gráfica
 * IDE: Visual Studio Community 2022(64-bit) - Version: 17.4.3
 */

namespace Jogo_da_velha
{
    public partial class FormGame : Form
    {
        private const string VAZIO = "";
        private const string MENSAGEM_1 = "O jogador 1 venceu! Deseja jogar outra partida?";
        private const string MENSAGEM_2 = "O jogador 2 venceu! Deseja jogar outra partida?";
        private const string MENSAGEM_3 = "O jogo empatou! Deseja jogar outra partida?";

        private bool jogador_1 = true;
        private bool jogador_2 = false;
        private DialogResult resposta;
      

        public FormGame()
        {
            InitializeComponent();        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ChecarJogador(button1);
            ChecarEstado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChecarJogador(button2);
            ChecarEstado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChecarJogador(button3);
            ChecarEstado();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChecarJogador(button4);
            ChecarEstado();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChecarJogador(button5);
            ChecarEstado();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChecarJogador(button6);
            ChecarEstado();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChecarJogador(button7);
            ChecarEstado();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChecarJogador(button8);
            ChecarEstado();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChecarJogador(button9);
            ChecarEstado();          
        }


        ///
        /// Checa de qual jogador é a vez e assinala 'X' ou 'O' conforme apropriado, após o clique no campo vazio.
        ///
        private void ChecarJogador(Button botao)
        {
            if (jogador_1 == true && botao.Text == VAZIO)
            {
                botao.Text = "X";
                botao.Font = new Font("Comic Sans MS", 48, FontStyle.Bold);
                botao.ForeColor = Color.OrangeRed;
                jogador_1 = false;
                jogador_2 = true;
            }
            else if (jogador_2 == true && botao.Text == VAZIO)
            {
                botao.Text = "O";
                botao.Font = new Font("Comic Sans MS", 48, FontStyle.Bold);
                botao.ForeColor = Color.Turquoise;
                jogador_1 = true;
                jogador_2 = false;
            }
            else
            {
                // Não faz nada: Isso impede que 'X' sobrescreva 'O' e vice-versa, caso o campo já esteja marcado.
            }
        }
   
        
        ///
        /// Checa se um dos jogadores conseguiu completar uma linha vertical, horizontal, diagonal ou se deu "velha".
        ///
        private void ChecarEstado()
        {           
            if (button1.Text != VAZIO && button1.Text == button2.Text && button2.Text == button3.Text && jogador_1 == false)
            {
                button1.BackColor = Color.Aquamarine;
                button2.BackColor = Color.Aquamarine;
                button3.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }           
            else if (button1.Text != VAZIO && button1.Text == button2.Text && button2.Text == button3.Text && jogador_1 == true)
            {
                button1.BackColor = Color.Aquamarine;
                button2.BackColor = Color.Aquamarine;
                button3.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }               

            if (button4.Text != VAZIO && button4.Text == button5.Text && button5.Text == button6.Text && jogador_1 == false)
            {
                button4.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button6.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }           
            else if (button4.Text != VAZIO && button4.Text == button5.Text && button5.Text == button6.Text && jogador_1 == true)
            {
                button4.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button6.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }                

            if (button7.Text != VAZIO && button7.Text == button8.Text && button8.Text == button9.Text && jogador_1 == false)
            {
                button7.BackColor = Color.Aquamarine;
                button8.BackColor = Color.Aquamarine;
                button9.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }          
            else if (button7.Text != VAZIO && button7.Text == button8.Text && button8.Text == button9.Text && jogador_1 == true)
            {
                button7.BackColor = Color.Aquamarine;
                button8.BackColor = Color.Aquamarine;
                button9.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }                

            if (button1.Text != VAZIO && button1.Text == button4.Text && button4.Text == button7.Text && jogador_1 == false)
            {
                button1.BackColor = Color.Aquamarine;
                button4.BackColor = Color.Aquamarine;
                button7.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }            
            else if (button1.Text != VAZIO && button1.Text == button4.Text && button4.Text == button7.Text && jogador_1 == true)
            {
                button1.BackColor = Color.Aquamarine;
                button4.BackColor = Color.Aquamarine;
                button7.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }               

            if (button2.Text != VAZIO && button2.Text == button5.Text && button5.Text == button8.Text && jogador_1 == false)
            {
                button2.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button8.BackColor = Color.Aquamarine;
                
                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }        
            else if (button2.Text != VAZIO && button2.Text == button5.Text && button5.Text == button8.Text && jogador_1 == true)
            {
                button2.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button8.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }                

            if (button3.Text != VAZIO && button3.Text == button6.Text && button6.Text == button9.Text && jogador_1 == false)
            {
                button3.BackColor = Color.Aquamarine;
                button6.BackColor = Color.Aquamarine;
                button9.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }           
            else if (button3.Text != VAZIO && button3.Text == button6.Text && button6.Text == button9.Text && jogador_1 == true)
            {
                button3.BackColor = Color.Aquamarine;
                button6.BackColor = Color.Aquamarine;
                button9.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }              

            if (button1.Text != VAZIO && button1.Text == button5.Text && button5.Text == button9.Text && jogador_1 == false)
            {
                button1.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button9.BackColor = Color.Aquamarine;
                
                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }          
            else if (button1.Text != VAZIO && button1.Text == button5.Text && button5.Text == button9.Text && jogador_1 == true)
            {
                button1.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button9.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }           

            if (button3.Text != VAZIO && button3.Text == button5.Text && button5.Text == button7.Text && jogador_1 == false)
            {
                button3.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button7.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_1, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }              
            else if (button3.Text != VAZIO && button3.Text == button5.Text && button5.Text == button7.Text && jogador_1 == true)
            {
                button3.BackColor = Color.Aquamarine;
                button5.BackColor = Color.Aquamarine;
                button7.BackColor = Color.Aquamarine;

                resposta = MessageBox.Show(MENSAGEM_2, "Game Over", MessageBoxButtons.YesNo);
                ChecarSaida(resposta);
            }
            else
            { 
                if (button1.Text != VAZIO && button2.Text != VAZIO && button3.Text != VAZIO &&
                    button4.Text != VAZIO && button5.Text != VAZIO && button6.Text != VAZIO && 
                    button7.Text != VAZIO && button8.Text != VAZIO && button9.Text != VAZIO)
                {
                    Button[] botoes = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

                    foreach (Button botao in botoes)
                    {
                        botao.BackColor = Color.LightGray;
                    }                   

                    resposta = MessageBox.Show(MENSAGEM_3, "Game Over", MessageBoxButtons.YesNo);
                    ChecarSaida(resposta);
                }                                      
            }                  
        }


        ///
        /// Checa se o usuário clicou 'sim' ou 'não' após aparecer a caixa de mensagem no fim de jogo, e executa a ação apropriada conforme a resposta.
        ///
        private void ChecarSaida(DialogResult saida)
        {
            if (saida == DialogResult.Yes)
            {
                Button[] botoes = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

                foreach (Button botao in botoes)
                {
                    botao.Text = VAZIO;
                    botao.BackColor = Color.White;
                }

                jogador_1 = true;
                jogador_2 = false;
            }
            else if (saida == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}