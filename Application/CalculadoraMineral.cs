using System;
using CalculadoraDeReservaMineral.Domain;
using CalculadoraDeReservaMineral.Types;

namespace CalculadoraDeReservaMineral.Application
{
    public class CalculadoraMineral
    {
        /// <summary>
        /// (M) Minerais Brutos. Essencialmente pedra sem valor com minerais preciosos dentro.
        /// </summary>
        public double MineralBruto { get; set; }
        /// <summary>
        /// (C) Variável de Conversão.
        /// </summary>
        public double VariavelConversao { get; set; }
        /// <summary>
        /// (MC) Mineral Convertido. Ou seja, o valor do mineral bruto convertido em outra medida.
        /// </summary>
        public double MineralConvertido { get; set; }
        /// <summary>
        /// (G) Equação de Grau do mineral.
        /// Ou seja, a quantidade do mineral precioso bruto que existe dentro da camada de rocha bruta.
        /// Por exemplo, 100.000 toneladas de mineral bruto com 10% de Fe (Ferro) tem 10.000 toneladas de Ferro.
        /// </summary>
        public double EquacaoGrauMineral { get; set; }
        /// <summary>
        /// (MG) Mineral Graduado.
        /// M após a equação com G.
        /// Usado quando a graduação do mineral bruto acontece antes da conversão,
        /// e feito quando o valor inicial não é tonelada e não será medido por um valor compatível com toneladas - por exemplo,
        /// toneladas métricas com toneladas curtas por gramas (st/g).
        /// </summary>
        public double MineralGraduado { get; set; }
        /// <summary>
        /// (MCG) Mineral Convertido Grau. Ou seja, ele é o mineral convertido que tem seu grau calculado, e no fim é mostrado na tela.
        /// </summary>
        public double MineralConvertidoGrau { get; set; }

        public UnidadeMineral UnidadeMineral { get; set; }
        public GrauMineral GrauMineral { get; set; }
        
        public CalculadoraMineral(UnidadeMineral unidadeMineral, GrauMineral grauMineral)
        {
            UnidadeMineral = unidadeMineral;
            GrauMineral = grauMineral;
        }

        public void SetVolumeMineral(int volMineral) => MineralBruto = volMineral;

        public void SetGrauMineral(int grauMineral) => EquacaoGrauMineral = grauMineral;

        public double Calcular()
        {
            double resultado = 0;
            switch (UnidadeMineral)
            {
                case UnidadeMineral.ToneladasMetricas:
                    resultado = CalcularToneladasMetricas(GrauMineral);
                    break;
                case UnidadeMineral.Libras:
                    break;
                case UnidadeMineral.Oncas:
                    break;
                case UnidadeMineral.OncasTroy:
                    break;
                case UnidadeMineral.ToneladasCurtas:
                    break;
                case UnidadeMineral.ToneladasImperiais:
                    break;
                case UnidadeMineral.Megatons:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return resultado;
        }

        private double CalcularToneladasMetricas(GrauMineral grauMineral)
        {
            double resultado = 0;
            switch (grauMineral)
            {
                case GrauMineral.Porcentagem:
                    resultado = Math.Ceiling(EquacaoGrauMineral / 100d * MineralBruto);
                    break;
                case GrauMineral.GramasToneladas:
                    resultado = EquacaoGrauMineral / 1000000d * MineralBruto;
                    break;
                default:
                    // ArgumentOutOfRangeException(nameof(grauMineral), grauMineral, null)
                    throw new Exception($"Toneladas Metricas não podem ser calculadas por: {grauMineral}");
            }

            return resultado;
        }
    }
}