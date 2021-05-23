# Calculadora-de-Reserva-Mineral
 Programa em C# capaz de calcular uma reserva mineral.

Finalidade: Calcular o quanto de mineral de minério (ou seja, o minério em si, não a rocha bruta na qual ele se encontra) existe numa certa massa de minério.


Como executar: Entre na pasta bin/debug, execute o arquivo Calculadora de Reserva Mineral.exe. Ele abrirá imediatamente o programa.

Como usar: 

1. Selecione a Unidade dos Minerais, ou seja, em que Medida de Peso e Massa o mineral bruto se encontra. Atualmente, existem as seguintes opções:

- Toneladas Métricas/T (Padrão)
- Libras/Lbs
- Onças/Oz
- Onças Troy/Oz t (geralmente usadas para medir ouro e similares metais preciosos)
- Toneladas Curtas/St
- Toneladas Imperiais/UKT
- Megatons/MT 


2. Selecione o Grau dos Minerais. O Grau é a porcentagem ou medida de proporção dos minerais. É possivel escolher os seguintes, embora nem todos sejam usáveis com todas as unidades:
- Porcentagem (%)
- Gramas por Tonelada (g/t) ou Partes por Milhão (PPM). Sim, ambos são a mesma coisa, porque 1 milhão de gramas são 1 tonelada.
- Gramas por Tonelada Curta (g/st)
- Gramas por Onça (g/oz)
- Gramas por Onça Troy (g/oz t)

Caso uma Unidade e um Grau não sejam compativeis (por exemplo, Unidade Tonelada e Grau Gramas por Onça Troy), o usuário será avisado por meio de uma mensagem e o calculo será cancelado. 


3. Liste a quantidade dos minerais na caixa de texto escrita "Minerais". Lembre-se: O número que você vai listar estará na medida da unidade que você escolheu.

4. Aperte o botão "Converter."

5. O resultado será mostrado na caixa de texto abaixo, com o resultado final sendo convertido para Toneladas Métricas.

Um exemplo: Toneladas/Porcentagem
124.500 toneladas métricas de mineral.
Grau: 20%
Resultado: 124580 Toneladas de Minério contem 20% de Minerais de Minério, com o total deles sendo 24916 Toneladas 


Exemplo 2: Onças e Gramas por Onça (g/oz):
124580 Onças contem 20 gramas por onça. 124580 Onças contém 2491600 gramas de Mineral de Minério, ou 2,4916 Toneladas de Mineral de Minério. 


Planos para versões futuras:
1. Um código mais elegante e refinado.
2. A possibilidade do resultado ser em qualquer unidade (no momento o resultado final é apenas em toneladas métricas)
3. Uma interface mais bonitinha





Changelog:

- Versão 1.0 da Calculadora de Reserva Mineral upada no Github. 
