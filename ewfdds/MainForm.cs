using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ewfdds
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		string respostacerta = "X";
		int pontos = 0;
		string nomeImagem = "transferir.jpg";
		string imageme = "imagem.jpg";
		
		//Alternativas
		void ButtonAClick(object sender, EventArgs e)
		{
			if (respostacerta == "A")
			{
				pictureBox1.Load(nomeImagem);
				MessageBox.Show("Você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				pictureBox1.Load(imageme);
				MessageBox.Show("Você errou kkkkkkk");
			}
			panel1.Enabled = false;
		}
		void ButtonBClick(object sender, EventArgs e)
		{
			if (respostacerta == "B")
			{
				pictureBox1.Load(nomeImagem);
				MessageBox.Show("Parabéns, você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				pictureBox1.Load(imageme);
				MessageBox.Show("Você errou!!!");
			}
			panel1.Enabled = false;
		}
		void ButtonCClick(object sender, EventArgs e)
		{
			if (respostacerta == "C")
			{
				pictureBox1.Load(nomeImagem);
				MessageBox.Show("Parabéns, você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				pictureBox1.Load(imageme);
				MessageBox.Show("Você errou!!!");
			}
			panel1.Enabled = false;
		}
		void ButtonDClick(object sender, EventArgs e)
		{
			if (respostacerta == "D")
			{
				pictureBox1.Load(nomeImagem);
				MessageBox.Show("Parabéns, você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				pictureBox1.Load(imageme);
				MessageBox.Show("Você errou!!!");
			}
			panel1.Enabled = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Qual foi o papel dos computadores na corrida espacial?";
			labelA.Text = "Usar o google para estudar sobre o espaço";
			labelB.Text = "Usados para pegar informações da união soviética";
			labelC.Text = "Usados em calculos";
			labelD.Text = "Usados para simular gravitação";
			respostacerta = "C";
			nomeImagem = "brabo.jpg";
			
			panel1.Enabled = true;
			
			button1.Enabled = false;
			button2.Enabled = true;
			buttomReiniciar.Enabled = true;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "1.Como a Internet mudou o paradigma de computação pessoal e de negócios desde sua popularização nos anos 1990?";
			labelA.Text = "A internet possibilitou acesso fácil a negócios, informaçoes rápidas, \r além de muitas coisas";
			labelB.Text = "A internet não mudou nada";
			labelC.Text = "A internet apenas possibilitou o acesso a conexões em distância e \r acesso a informações rápidas";
			labelD.Text = "A internet não revolucionou nada dos computadores";
			respostacerta = "A";
			nomeImagem = "anternet.jpg";
			
			panel1.Enabled = true;
			
			button2.Enabled = false;
			button3.Enabled = true;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Quais foram os principais avanços em hardware que permitiram a criação de computadores modernos?";
			labelA.Text = "GPU, Ram, CPU e SSD";
			labelB.Text = "GPU, CPU,  placa mãe, HDD";
			labelC.Text = "Placas integradas, GPU, RAM e armazenamentos";
			labelD.Text = "Não teve";
			respostacerta = "C";
			nomeImagem = "hardware.jpg";
			
			panel1.Enabled = true;
			
			button3.Enabled = false;
			button4.Enabled = true;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "De que maneira os primeiros jogos de computador, como o Spacewar! influenciaram a indústria de videogames?";
			labelA.Text = "Ele revolucionou a forma de programar";
			labelB.Text = "Ele foi um dos primeiros jogos desenvolvidos que mostrou que \r o computador pode nos trazer diversão";
			labelC.Text = "Trouxea demanda de hardwares mais potentes";
			labelD.Text = "Não teve influência nenhuma";
			respostacerta = "B";
			nomeImagem = "spacewar!.jpg";
			
			panel1.Enabled = true;
			
			button4.Enabled = false;
			button5.Enabled = true;
		}
		void ButtomReiniciarClick(object sender, EventArgs e)
		{
			Application.Restart();
		}
		void Button5Click(object sender, EventArgs e)
		{
				
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Qual foi a primeira linguagem de programação do mundo?";
			labelA.Text = "C";
			labelB.Text = "Java";
			labelC.Text = "Python";
			labelD.Text = "Fortran";
			respostacerta = "D";
			nomeImagem = "Fortran.png";
			
			panel1.Enabled = true;
			
			button5.Enabled = false;
			button6.Enabled = true;
		}
		void Button6Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Qual sistema operacional veio primeiro?";
			labelA.Text = "Windows ";
			labelB.Text = "GNU";
			labelC.Text = "Linux";
			labelD.Text = "GM-NAA I/O";
			respostacerta = "D";
			nomeImagem = "GMNAA_IO.jpg";
			
			panel1.Enabled = true;
			
			button6.Enabled = false;
			button7.Enabled = true;
		}
		void Button7Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Qual foi o primeiro sistema de armazenamento da históra dos computadores?";
			labelA.Text = "SSD";
			labelB.Text = "Fita_K7";
			labelC.Text = "Disket";
			labelD.Text = "Pen-Drive";
			respostacerta = "B";
			nomeImagem = "Fita_K7.jpg";
			
			panel1.Enabled = true;
			
			button7.Enabled = false;
			button8.Enabled = true;
		}
		void Button8Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Qual foi a primeira placa de video da história?";
			labelA.Text = "Monochrome Display Adapter";
			labelB.Text = "RX 500";
			labelC.Text = "GTX 1080";
			labelD.Text = "RTX 2040";
			respostacerta = "A";
			nomeImagem = "monochrome.jpg";
			
			panel1.Enabled = true;
			
			button8.Enabled = false;
			button9.Enabled = true;
		}
		void Button9Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Quem veio primeiro, Linux ou windows?";
			labelA.Text = "Linux";
			labelB.Text = "Windows";
			labelC.Text = "Os dois ao mesmo tempo";
			labelD.Text = "Os não existem";
			respostacerta = "A";
			nomeImagem = "linux.png";
			
			panel1.Enabled = true;
			
			button9.Enabled = false;
			button10.Enabled = true;
		}
		void Button10Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Quem iniciou a idéia do primeiro computador da história?";
			labelA.Text = "Charles Babbage";
			labelB.Text = "Oppenheimer";
			labelC.Text = "Charles Darwin";
			labelD.Text = "Bill Gates";
			respostacerta = "A";
			nomeImagem = "Charles.jpg";
			
			panel1.Enabled = true;
			
			button10.Enabled = false;
			buttonfinalizar.Enabled = true;
		}
		void ButtonfinalizarClick(object sender, EventArgs e)
		{
			if (pontos == 0)
			{
				MessageBox.Show("Estude mais. Você não domina nada do assunto");
				Application.Restart();
			}
			else
			{
				if (pontos >= 1 && pontos <= 4)
				{
					MessageBox.Show("Seu conhecimento é de iniciante");
					Application.Restart();
				}
				else
				{
					if(pontos >= 5 && pontos <= 7)
					{
						MessageBox.Show("Você tem um bom conhecimento");
						Application.Restart();
					}
					else
					{
						if(pontos >= 8 && pontos <= 9)
						{
							MessageBox.Show("Seu conhecimento é excepcional");
							Application.Restart();
						}
						else
						{
							MessageBox.Show("Você e um gênio");
							Application.Restart();
						}
					}
				}
			}
		}
	}
}