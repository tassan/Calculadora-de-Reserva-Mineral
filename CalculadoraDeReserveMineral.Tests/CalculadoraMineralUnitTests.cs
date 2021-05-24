using System;
using CalculadoraDeReservaMineral.Application;
using CalculadoraDeReservaMineral.Types;
using Xunit;
using FakeItEasy;

namespace CalculadoraDeReserveMineral.Tests
{
    public class CalculadoraMineralUnitTests
    {
        public CalculadoraMineral CalculadoraMineral { get; set; }

        
        [Theory]
        [InlineData(10, 100, 10d)]
        [InlineData(15, 140, 21d)]
        [InlineData(2000, 963, 19260d)]
        public void Teste_Calculo_ToneladasMetricas_Por_Porcentagem(int volMineral, int grauMineral, double resultadoEsperado)
        {
            // Arrange
            CalculadoraMineral = new CalculadoraMineral(UnidadeMineral.ToneladasMetricas, GrauMineral.Porcentagem);
            CalculadoraMineral.SetVolumeMineral(volMineral);
            CalculadoraMineral.SetGrauMineral(grauMineral);

            // Act
            var resultado = CalculadoraMineral.Calcular();
            
            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Teste_Calculo_ToneladasMetricas_Por_GramasTonelada()
        {
            // Arrange
            CalculadoraMineral = new CalculadoraMineral(UnidadeMineral.ToneladasMetricas, GrauMineral.GramasToneladas);
            CalculadoraMineral.SetVolumeMineral(10);
            CalculadoraMineral.SetGrauMineral(100);
            
            // Act
            var resultado = CalculadoraMineral.Calcular();
            
            // Asset
            Assert.Equal(0.001, resultado);
        }
        
        [Fact]
        public void Teste_Calculo_ToneladasMetricas_Por_GramasToneladaCurta()
        {
            CalculadoraMineral = new CalculadoraMineral(UnidadeMineral.ToneladasMetricas, GrauMineral.GramasToneladaCurta);
            CalculadoraMineral.SetVolumeMineral(10);
            CalculadoraMineral.SetGrauMineral(100);

            Assert.Throws<Exception>(() => CalculadoraMineral.Calcular());
        }
        
        [Fact]
        public void Teste_Calculo_ToneladasMetricas_Por_GramasOnca()
        {
            CalculadoraMineral = new CalculadoraMineral(UnidadeMineral.ToneladasMetricas, GrauMineral.GramasOnca);
            CalculadoraMineral.SetVolumeMineral(10);
            CalculadoraMineral.SetGrauMineral(100);

            Assert.Throws<Exception>(() => CalculadoraMineral.Calcular());
        }
        
        [Fact]
        public void Teste_Calculo_ToneladasMetricas_Por_GramasOncaTroy()
        {
            CalculadoraMineral = new CalculadoraMineral(UnidadeMineral.ToneladasMetricas, GrauMineral.GramasOncaTroy);
            CalculadoraMineral.SetVolumeMineral(10);
            CalculadoraMineral.SetGrauMineral(100);

            Assert.Throws<Exception>(() => CalculadoraMineral.Calcular());
        }
    }
}