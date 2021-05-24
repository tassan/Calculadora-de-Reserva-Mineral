using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraDeReservaMineral;
using CalculadoraDeReservaMineral.Application;

//Criado por: Filipe Augusto. Até onde lembro, o código é inteiramente original. 

namespace CalculadoraDeReservaMineral
{
	public partial class Form1 : Form
	{
		public CalculadoraMineral CalculadoraMineral { get; set; }
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}


		private void btnConverter_Click(object sender, EventArgs e)
			{
				if (string.IsNullOrEmpty(txtBoxMinerais.Text)) //Se a caixa de texto dos minerais tem apenas uma string vazia, sem nada, em branco ou nula
				{
					MessageBox.Show("Erro! Valor vazio ou nulo!");
					return;
				} //Avisa caso o valor da caixa de texto dos minerais estiver vazio, e impede a realização de calculos usando um objeto vazio ou algo idiota assim.
				
				if (rdBtnToneladasMetricas.Checked == true) //tonelada é o valor padrão, não converte. No futuro, talvez eu permita converter de todos os pesos para todos os outros pesos.
				{
					Variaveis VolumeMineral = new Variaveis(); //criação de objeto VolumeMineral. VolumeMineral é composto da Classe Variaveis.
					VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text); //Diz que o valor de M é o mesmo do que está escrito na txtBoxMinerais e converte o conteudo da txtBox de string para double, de forma que ele possa ser usado para calculos matemáticos. 
					VolumeMineral.MC = VolumeMineral.M; //Tonelada para tonelada não converte, então MC é igual à M. No futuro, isso provavelmente não será verdade e Tonelada não será a medida padrão
				    
					if (rdBtnPorcentagem.Checked == true) //calcula o grau do mineral pela porcentagem
					{
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MCG = (GrauMineral.G / 100d) * VolumeMineral.MC; //Calculo da porcentagem. No caso, G divido por 100 vezes MC. Traduzindo: Grau é divido por 100 (porCENto) e em seguida, multiplicado pelo valor de MC, ou Mineral Convertido.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Toneladas de Minério contem" + ' ' + Convert.ToString(GrauMineral.G)+"% de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' ' ; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as três informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladaPPM.Checked == true)
					{
						Variaveis GrauMineral = new Variaveis(); //criação de objeto
						GrauMineral.G = Convert.ToDouble(txtGrau.Text);
						GrauMineral.MCG = (GrauMineral.G / 1000000d) * VolumeMineral.MC; //1 ppm = 0.001%. E 1.000.000 gramas é igual à uma tonelada, ou seja, 1 parte por milhão.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Toneladas de Minério contem" + ' ' + Convert.ToString(GrauMineral.G) + " " + "Partes por Milhão ou Gramas por Toneladas de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as três informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladasCurtas.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Tonelada Curta (g/st), se sua unididade inicial atual é Tonelada Métrica. Altere a Unidade do Mineral para Toneladas Curtas!");
						return;
					}
					else if (rdBtnGramasOnca.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça (g/oz), se sua unididade inicial atual é Tonelada Métrica. Altere a Unidade do Mineral para Onças(oz)!");
						return;
					}
					else if (rdBtnGramasOncaTroy.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça Troy (g/oz t), se sua unididade inicial atual é Tonelada Métrica. Altere a Unidade do Mineral para Onças Troy(oz t)!");
						return;
					}
				}
				else if (rdBtnLibras.Checked == true)
				{
					Variaveis VolumeMineral = new Variaveis(); //criação de objeto 
					VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text); //Variável M é convertida
					VolumeMineral.C = 2204.62262d;
					VolumeMineral.MC = VolumeMineral.M / VolumeMineral.C;

					if (rdBtnPorcentagem.Checked == true)
					{
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MCG = (GrauMineral.G / 100d) * VolumeMineral.MC; //Calculo da porcentagem. No caso, G divido por 100 vezes MC. Traduzindo: Grau é divido por 100 (porCENto) e em seguida, multiplicado pelo valor de MC, ou Mineral Convertido.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Libras" + ' ' + "foram convertidas em" + ' ' + Convert.ToString(VolumeMineral.MC) + ' ' + "Toneladas" + ' ' + "de Minério que contem" + ' ' + Convert.ToString(GrauMineral.G) + "% de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Em seguida, o valor convertido para toneladas. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladaPPM.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Partes Por Milhão (PMM) ou Gramas por Tonelada (g/t), se sua unididade inicial atual é a Libra. Altere a Unidade do Mineral para Toneladas ou Megaton primeiro!");
						return;
					}
					else if (rdBtnGramasToneladasCurtas.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Tonelada Curta (g/st), se sua unididade inicial atual é a Libra. Altere a Unidade do Mineral para Toneladas Curtas (st)   primeiro!");
						return;
					}
					else if (rdBtnGramasOnca.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça (g/oz), se sua unididade inicial atual é a Libra. Altere a Unidade do Mineral para Onça (oz) primeiro!");
						return;
					}
					else if (rdBtnGramasOncaTroy.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça Troy (g/oz t), se sua unididade inicial atual é a Libra. Altere a Unidade do Mineral para Onça Troy(oz t) primeiro!");
						return;
					}

				}
				else if (rdBtnOncas.Checked == true)
				{
				
				//Aqui não vamos converter no inicio.

					if (rdBtnPorcentagem.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						VolumeMineral.C = 35273.962d;
						VolumeMineral.MC = VolumeMineral.M / VolumeMineral.C;
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MCG = (GrauMineral.G / 100d) * VolumeMineral.MC; //Calculo da porcentagem. No caso, G divido por 100 vezes MC. Traduzindo: Grau é divido por 100 (porCENto) e em seguida, multiplicado pelo valor de MC, ou Mineral Convertido.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Onças" + ' ' + "foram convertidas em" + ' ' + Convert.ToString(VolumeMineral.MC) + ' ' + "Toneladas" + ' ' + "de Minério que contem" + ' ' + Convert.ToString(GrauMineral.G) + "% de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Em seguida, o valor convertido para toneladas. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasOnca.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MG = VolumeMineral.M * GrauMineral.G; //No caso, para saber quantas gramas por oz tem nessa quantidade de onças (expressas em M), devemos multiplicar M por G.
						GrauMineral.MCG = GrauMineral.MG / 1000000d; //Aqui vamos converter as gramas de MG em Toneladas. Para isso, devemos dividir por um milhão. 
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Onças" + ' ' + "contem" + ' ' + Convert.ToString(GrauMineral.G) + ' ' + "gramas por onça." + ' ' + VolumeMineral.M + ' ' + "Onças contém" + ' ' + Convert.ToString(GrauMineral.MG) + ' ' + "gramas de Mineral de Minério, ou " + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas de Mineral de Minério." + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original de mineral de minério, em onças. Em seguida, a quantidade de gramas por onça, que é o nosso grau. Subsequentemente, vemos a quantidade original de onças novamente e o total de gramas nelas. E após isso, a conversão dessas gramas em toneladas. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladaPPM.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Partes Por Milhão (PMM) ou Gramas por Tonelada (g/t), se sua unididade inicial atual é a Onça. Altere a Unidade do Mineral para Toneladas ou Megaton primeiro!");
						return;
					}
					else if (rdBtnGramasToneladasCurtas.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Tonelada Curta (g/st), se sua unididade inicial atual é a Onça. Altere a Unidade do Mineral para Toneladas Curtas (st)   primeiro!");
						return;
					}
					else if (rdBtnGramasOncaTroy.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça Troy (g/oz t), se sua unididade inicial atual é a Onça. Altere a Unidade do Mineral para Onça Troy(oz t) primeiro!");
						return;
					}
				}
				else if (rdBtnOncasTroy.Checked == true)
				{

					//Aqui não vamos converter no inicio.

					if (rdBtnPorcentagem.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						VolumeMineral.C = 32150.7466d; //conversão de onça troy para toneladas.
						VolumeMineral.MC = VolumeMineral.M / VolumeMineral.C;
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MCG = (GrauMineral.G / 100d) * VolumeMineral.MC; //Calculo da porcentagem. No caso, G divido por 100 vezes MC. Traduzindo: Grau é divido por 100 (porCENto) e em seguida, multiplicado pelo valor de MC, ou Mineral Convertido.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Onças Troy" + ' ' + "foram convertidas em" + ' ' + Convert.ToString(VolumeMineral.MC) + ' ' + "Toneladas" + ' ' + "de Minério que contem" + ' ' + Convert.ToString(GrauMineral.G) + "% de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Em seguida, o valor convertido para toneladas. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasOncaTroy.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MG = VolumeMineral.M * GrauMineral.G; //No caso, para saber quantas gramas por oz tem nessa quantidade de onças (expressas em M), devemos multiplicar M por G.
						GrauMineral.MCG = GrauMineral.MG / 1000000d; //Aqui vamos converter as gramas de MG em Toneladas. Para isso, devemos dividir por um milhão. 
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Onças Troy" + ' ' + "contem" + ' ' + Convert.ToString(GrauMineral.G) + ' ' + "gramas por onça troy." + ' ' + VolumeMineral.M + ' ' + "Onças troy contém" + ' ' + Convert.ToString(GrauMineral.MG) + ' ' + "gramas de Mineral de Minério, ou " + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas de Mineral de Minério." + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original de mineral de minério, em onças. Em seguida, a quantidade de gramas por onça troy, que é o nosso grau. Subsequentemente, vemos a quantidade original de onças novamente e o total de gramas nelas. E após isso, a conversão dessas gramas em toneladas. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladaPPM.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Partes Por Milhão (PMM) ou Gramas por Tonelada (g/t), se sua unididade inicial atual é a Onça. Altere a Unidade do Mineral para Toneladas ou Megaton primeiro!");
						return;
					}
					else if (rdBtnGramasToneladasCurtas.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Tonelada Curta (g/st), se sua unididade inicial atual é a Onça. Altere a Unidade do Mineral para Toneladas Curtas (st)   primeiro!");
						return;
					}
					else if (rdBtnGramasOnca.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça(g/oz), se sua unididade inicial atual é a Onça Troy. Altere a Unidade do Mineral para Onça(oz) primeiro!");
						return;
					}
				}
				else if (rdBtnToneladasCurtas.Checked == true)
				{
					//Aqui não vamos converter no inicio

					if (rdBtnPorcentagem.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						VolumeMineral.C = 1.10231131d; //conversão de Toneladas Curtas para Toneladas Métricas
						VolumeMineral.MC = VolumeMineral.M / VolumeMineral.C;
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MCG = (GrauMineral.G / 100d) * VolumeMineral.MC; //Calculo da porcentagem. No caso, G divido por 100 vezes MC. Traduzindo: Grau é divido por 100 (porCENto) e em seguida, multiplicado pelo valor de MC, ou Mineral Convertido.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Toneladas Curtas" + ' ' + "foram convertidas em" + ' ' + Convert.ToString(VolumeMineral.MC) + ' ' + "Toneladas" + ' ' + "de Minério que contem" + ' ' + Convert.ToString(GrauMineral.G) + "% de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Em seguida, o valor convertido para toneladas. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladasCurtas.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MG = VolumeMineral.M * GrauMineral.G; //No caso, para saber quantas gramas por oz tem nessa quantidade de onças (expressas em M), devemos multiplicar M por G.
						GrauMineral.MCG = GrauMineral.MG / 1000000d; //Aqui vamos converter as gramas de MG em Toneladas. Para isso, devemos dividir por um milhão. 
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Toneladas Curtas" + ' ' + "contem" + ' ' + Convert.ToString(GrauMineral.G) + ' ' + "gramas por tonelada curta." + ' ' + VolumeMineral.M + ' ' + "Toneladas curtas contém" + ' ' + Convert.ToString(GrauMineral.MG) + ' ' + "gramas de Mineral de Minério, ou " + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas de Mineral de Minério." + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original de mineral de minério, em onças. Em seguida, a quantidade de gramas por onça troy, que é o nosso grau. Subsequentemente, vemos a quantidade original de onças novamente e o total de gramas nelas. E após isso, a conversão dessas gramas em toneladas. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladaPPM.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Partes Por Milhão (PMM) ou Gramas por Tonelada (g/t), se sua unididade inicial atual é a Tonelada Curta. Altere a Unidade do Mineral para Toneladas ou Megaton primeiro!");
						return;
					}
					else if (rdBtnGramasOnca.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça(g/oz), se sua unididade inicial atual é a Tonelada Curta. Altere a Unidade do Mineral para Onça(oz) primeiro!");
						return;
					}
					else if (rdBtnGramasOncaTroy.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça Troy (g/oz t), se sua unididade inicial atual é a Tonelada Curta. Altere a Unidade do Mineral para Onça Troy(oz t) primeiro!");
						return;
					}
				}
				else if (rdBtnToneladasImperais.Checked == true)
				{
					
					if (rdBtnPorcentagem.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						VolumeMineral.C = 1.01604691d; //conversão de Toneladas Imperais para Toneladas Métricas
						VolumeMineral.MC = VolumeMineral.M * VolumeMineral.C;
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text); //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MCG = (GrauMineral.G / 100d) * VolumeMineral.MC; //Calculo da porcentagem. No caso, G divido por 100 vezes MC. Traduzindo: Grau é divido por 100 (porCENto) e em seguida, multiplicado pelo valor de MC, ou Mineral Convertido.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Toneladas Imperais" + ' ' + "foram convertidas em" + ' ' + Convert.ToString(VolumeMineral.MC) + ' ' + "Toneladas" + ' ' + "de Minério que contem" + ' ' + Convert.ToString(GrauMineral.G) + "% de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Em seguida, o valor convertido para toneladas. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente. 
					}
					else if (rdBtnGramasToneladaPPM.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Partes Por Milhão (PPM) ou Gramas por Tonelada (g/t), se sua unididade inicial atual é a Tonelada Imperial. Altere a Unidade do Mineral para Toneladas ou Megaton primeiro!");
						return;
					}
					else if (rdBtnGramasToneladasCurtas.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Tonelada Curta (g/st), se sua unididade inicial atual é a Tonelada Imperial. Altere a Unidade do Mineral para Toneladas Curtas (st)   primeiro!");
						return;
					}
					else if (rdBtnGramasOnca.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça(g/oz), se sua unididade inicial atual é a Tonelada Imperial. Altere a Unidade do Mineral para Onça(oz) primeiro!");
						return;
					}
					else if (rdBtnGramasOncaTroy.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça Troy (g/oz t), se sua unididade inicial atual é a Tonelada Imperial. Altere a Unidade do Mineral para Onça Troy(oz t) primeiro!");
						return;
					}
				}
				else if (rdBtnMegatons.Checked == true)
				{
					//Sem converter no começo
					if (rdBtnPorcentagem.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						VolumeMineral.C = 1000000d; //conversão de Megatons para Toneladas Métricas
						VolumeMineral.MC = VolumeMineral.M * VolumeMineral.C;
						Variaveis GrauMineral = new Variaveis(); //criação de objeto Variáveis, ou seja, iremos usar a Classe Variáveis, que contem as variáveis, com o objeto GrauMineral.
						GrauMineral.G = Convert.ToDouble(txtGrau.Text);  //converte o número que está na caixa de texto Grau, transforma-o em um Double e envia a informação que à partir de agora, aquele número é o número da variável G.
						GrauMineral.MCG = (GrauMineral.G / 100d) * VolumeMineral.MC;  //Calculo da porcentagem. No caso, G divido por 100 vezes MC. Traduzindo: Grau é divido por 100 (porCENto) e em seguida, multiplicado pelo valor de MC, ou Mineral Convertido.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Megatons" + ' ' + "foram convertidas em" + ' ' + Convert.ToString(VolumeMineral.MC) + ' ' + "Toneladas" + ' ' + "de Minério que contem" + ' ' + Convert.ToString(GrauMineral.G) + "% de Minerais de Minério, com o total deles sendo" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas" + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as quatro informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Em seguida, o valor convertido para toneladas. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladaPPM.Checked == true)
					{
						Variaveis VolumeMineral = new Variaveis(); //criação de objeto	
						VolumeMineral.M = Convert.ToDouble(txtBoxMinerais.Text);
						VolumeMineral.C = 1000000d; //conversão de Megatons para Toneladas
						VolumeMineral.MC = VolumeMineral.M * VolumeMineral.C;
						Variaveis GrauMineral = new Variaveis(); //criação de objeto
						GrauMineral.G = Convert.ToDouble(txtGrau.Text);
						GrauMineral.MG = VolumeMineral.M * 1000000000000d; //No caso, para saber quantas gramas por toneladas tem nessa quantidade de megatons (expressas em M), devemos multiplicar M por um trilhão.
						GrauMineral.MCG = (GrauMineral.G / 1000000d) * VolumeMineral.MC; //1 ppm = 0.001%. E 1.000.000 gramas é igual à uma tonelada, ou seja, 1 parte por milhão. 1 megaton = 1.000.000 toneladas = 1.000.000.000.000 gramas.
						txtLogReservas.Text += Convert.ToString(VolumeMineral.M) + ' ' + "Megatons de Minério contem" + ' ' + Convert.ToString(GrauMineral.G) + " " + "Partes por Milhão ou Gramas por Toneladas de Minerais de Minério." + ' ' + Convert.ToString(VolumeMineral.M) + ' ' + "Megatons são iguais à" + ' ' + Convert.ToString(VolumeMineral.MC) + ' ' + "Toneladas, ou" + ' ' + Convert.ToString(GrauMineral.MG) + ' ' + "gramas." + ' '  + "Logo," +  ' ' + Convert.ToString(VolumeMineral.M) + ' ' + "Megatons contém" + ' ' + Convert.ToString(GrauMineral.MCG) + " " + "Toneladas de Mineral de Minério." + ' '; //Essa parte preenche a terceira caixa de texto com a informação convertida. Primeiro ela adiciona (+=) o conteudo de várias coisas: A ideia aqui é mostrar as três informações, como forma de ilustrar o processo. Primeiro, ele mostra o valor original. Depois, ele mostra o grau de quantidade de mineral de minério, em seguida ele mostra o total remanescente de mineral de minério após calcular o grau. As strings entre M, C, G e MCG permitem saber como foi o processo inteiro, tornando-o transparente.
					}
					else if (rdBtnGramasToneladasCurtas.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Tonelada Curta (g/st), se sua unididade inicial atual é o Megaton. Altere a Unidade do Mineral para Toneladas Curtas (st)   primeiro!");
						return;
					}
					else if (rdBtnGramasOnca.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça(g/oz), se sua unididade inicial atual é a Megaton. Altere a Unidade do Mineral para Onça(oz) primeiro!");
						return;
					}
					else if (rdBtnGramasOncaTroy.Checked == true)
					{
						MessageBox.Show("Aviso! Você não pode calcular Gramas por Onça Troy (g/oz t), se sua unididade inicial atual é a Megaton. Altere a Unidade do Mineral para Onça Troy(oz t) primeiro!");
						return;
					}
			}
			

			//Graus dos Minerais
			if (string.IsNullOrEmpty(txtGrau.Text))
					{
						MessageBox.Show("Erro! Valor de porcentagem vazio!");
						return;
					}
			}

		

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txtLogReservas.Clear(); //apaga o que está escrito em txtLogReservas
		}

		
		
		
		
		



		private void gpBoxUnidadeMinerais_Enter(object sender, EventArgs e)
		{

		}

		private void rdBtnToneladasImperais_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rdBtnToneladasMetricas_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rdBtnGramasOnca_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void txtBoxMinerais_TextChanged(object sender, EventArgs e)
		{

		}

		private void rdBtnGramasTonelada_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rdBtnPorcentagem_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
