using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Reserva_Mineral
{
	class Variaveis //quando aqui todas as variáveis para poder usar no contexto inteiro da aplicação e não ter problema com encapsulação.
	{
		public double M; //Minerais Brutos. Essencialmente pedra sem valor com minerais preciosos dentro.
		public double C; //Variável de Conversão. Ou seja, como vou converter o valor que coloquei para outro, e converter pelo quê.
		public double MC; //Mineral Convertido. Ou seja, o valor do mineral bruto convertido em outra medida.
		public double G; //Equação de Grau do mineral. Ou seja, a quantidade do mineral precioso bruto que existe dentro da camada de rocha bruta. Por exemplo, 100.000 toneladas de mineral bruto com 10% de Fe (Ferro) tem 10.000 toneladas de Ferro.
		public double MG; //Mineral Graduado. M após a equação com G. Usado quando a graduação do mineral bruto acontece antes da conversão, e feito quando o valor inicial não é tonelada e não será medido por um valor compatível com toneladas - por exemplo, toneladas métricas com toneladas curtas por gramas (st/g).
		public double MCG; //Mineral Convertido Grau. Ou seja, ele é o mineral convertido que tem seu grau calculado, e no fim é mostrado na tela.
	}
}
