using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvJogo21
{
    public partial class joga : Form
    {
        public joga()
        {
            InitializeComponent();

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;


        }

        Random rnd = new Random();
        int n1, n2, n3, n4, n5, n6, n7, n8;

        int nmrBaralho;
        int TotalJog;
        int TotalComputador;


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            n5 = rnd.Next(1, 14);
            if (n5 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox5.Load("baralho" + nmrBaralho + "-" + n5 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox5.Load("baralho" + nmrBaralho + "-" + n5 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + n5;
            }

            lblJogador.Text = TotalJog.ToString();

            if (TotalJog > 21)
            {
                MessageBox.Show("Estorou os 21 pontos!! Você perdeu!");
              


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }

            pictureBox5.Enabled = false;
            resetar();
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            iconButton2.Visible = false;
            iconButton1.Visible = true;

            n6 = rnd.Next(6, 14);
            n7 = rnd.Next(1, 7);
            n8 = rnd.Next(5, 9);
           


            if (n6 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox6.Load("baralho" + nmrBaralho + "-" + n6 + ".png");
                TotalComputador = int.Parse(lblComputador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox6.Load("baralho" + nmrBaralho + "-" + n6 + ".png");
                TotalComputador= int.Parse(lblComputador.Text) + n6;
            }

           

            if (n7 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox7.Load("baralho" + nmrBaralho + "-" + n7 + ".png");
                TotalComputador = int.Parse(lblComputador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox7.Load("baralho" + nmrBaralho + "-" + n7 + ".png");
                TotalComputador = int.Parse(lblComputador.Text) + n7;
            }


            if (n8 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox8.Load("baralho" + nmrBaralho + "-" + n8 + ".png");
                TotalComputador = int.Parse(lblComputador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox8.Load("baralho" + nmrBaralho + "-" + n8 + ".png");
                TotalComputador = int.Parse(lblComputador.Text) + n8;
            }



            if (TotalComputador > 21)
            {
                MessageBox.Show("Estorou os 21 pontos!! Você perdeu!");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }

         

            nmrBaralho = rnd.Next(1, 4);

           

            TotalComputador = n6 + n7 + n8;
            lblComputador.Text = TotalComputador.ToString();
         

            if (TotalComputador < TotalJog)
            {
                MessageBox.Show("Você Ganhou! Você pontuou melhor que o computador. Jogue novamente ...");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;

            }
            else if (TotalComputador > 21) 
            {
                MessageBox.Show("Você ganhou!! O computador ultrapassou a pontuação de corte ...");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }
            else if ( TotalComputador == TotalJog) 
            {
                MessageBox.Show("Empate!!! Tente jogar novamente ...");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }

            else 
            {
                MessageBox.Show("Você perdeu! O computador pontuou melhor. Tente novamente ...");
                resetar();

                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            n4 = rnd.Next(1, 14);   
            if (n4 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox4.Load("baralho" + nmrBaralho + "-" + n4 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox4.Load("baralho" + nmrBaralho + "-" + n4 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + n4;
            }

            lblJogador.Text = TotalJog.ToString();

            if (TotalJog > 21)      
            {
                MessageBox.Show("Estorou os 21 pontos!! Você perdeu!");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }

            pictureBox4.Enabled = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            n3 = rnd.Next(1, 14);
            if (n3 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox3.Load("baralho" + nmrBaralho + "-" + n3 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox3.Load("baralho" + nmrBaralho + "-" + n3 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + n3;
            }

            lblJogador.Text = TotalJog.ToString();

            if (TotalJog > 21)
            {
                MessageBox.Show("Estorou os 21 pontos!! Você perdeu!");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }

            pictureBox3.Enabled = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            n2 = rnd.Next(1, 14);
            if (n2 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox2.Load("baralho" + nmrBaralho + "-" + n2 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox2.Load("baralho" + nmrBaralho + "-" + n2 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + n2;
            }
     
            lblJogador.Text = TotalJog.ToString();
        
            if (TotalJog > 21)
            {
                MessageBox.Show("Estorou os 21 pontos!! Você perdeu!");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }

            pictureBox2.Enabled = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            n1 = rnd.Next(1, 14);
            if (n1 > 10)
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox1.Load("baralho" + nmrBaralho + "-" + n1 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + 10;

            }
            else
            {
                nmrBaralho = rnd.Next(1, 4);
                pictureBox1.Load("baralho" + nmrBaralho + "-" + n1 + ".png");
                TotalJog = int.Parse(lblJogador.Text) + n1;
            }

            lblJogador.Text = TotalJog.ToString();

            if (TotalJog > 21)
            {
                MessageBox.Show("Estorou os 21 pontos!! Você perdeu!");
                resetar();


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
            }

            pictureBox1.Enabled = false;
        }

        private void resetar() 
        {
            pictureBox1.Load("baralhoA.png");
            pictureBox2.Load("baralhoA.png");
            pictureBox3.Load("baralhoA.png");
            pictureBox4.Load("baralhoA.png");
            pictureBox5.Load("baralhoA.png");

            pictureBox6.Load("baralhoV.png");
            pictureBox7.Load("baralhoV.png");
            pictureBox8.Load("baralhoV.png");
          

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;

            lblComputador.Text = "0";
            lblJogador.Text = "0";

            n1 = 0;
            n2 = 0;
            n3 = 0;
            n4 = 0;
            n5 = 0;
            n6 = 0;
            n7 = 0;
            n8 = 0;

            int nmrBaralho = 0;
            int TotalJog = 0;
            int TotalComputador = 0;

            iconButton2.Visible = false;
            iconButton1.Visible = true;

            pictureBox5.Visible = false;
            pictureBox4.Visible = false;




        }
   

        private void iconButton1_Click(object sender, EventArgs e)
        {
            resetar();

            iconButton2.Visible = true;
            iconButton1.Visible = false;

         

        }
    }
}
