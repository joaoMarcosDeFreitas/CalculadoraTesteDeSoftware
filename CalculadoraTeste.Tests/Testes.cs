using CalculadoraTeste;

namespace CalculadoraTeste.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void CT001_SomarDuasParcelasPositivas()
        {
            Double parcela = 10;
            Double parcela1 = 20;

            Double soma = 30;

            Double somaObtida = Calculadora.Somar(parcela, parcela1);

            Assert.Equal(soma, somaObtida);
        }

        [Fact]
        public void CT002_SomarDuasParcelasPositivaENegativa()
        {
            Double parcela = 5.5;
            Double parcela1 = -10;

            Double soma = -4.5;

            Double somaObtida = Calculadora.Somar(parcela, parcela1);

            Assert.Equal(soma, somaObtida);
        }

        [Fact]
        public void CT003_MultiplicarDoisFatoresNegativos()
        {
            Double fator = -3.742;
            Double fator1 = -9.902;

            Double produto = 37.053284;

            Double produtoObtido = Calculadora.Multiplicar(fator, fator1);

            Assert.Equal(produto, produtoObtido);
        }

        [Fact]
        public void CT004_MultiplicarDoisFatoresPositivoE0()
        {
            Double fator = 10.89;
            Double fator1 = 0;

            Double produto = 0;

            Double produtoObtido = Calculadora.Multiplicar(fator, fator1);

            Assert.Equal(produto, produtoObtido);
        }

        [Fact]
        public void CT005_SubtrairMinuendoPositivoDeSubtraendoMaior()
        {
            Double minuendo = 10;
            Double subtraendo = 50;

            Double diferenca = -40;

            Double diferencaObtida = Calculadora.Subtrair(minuendo, subtraendo);

            Assert.Equal(diferenca, diferencaObtida);
        }

        [Fact]
        public void CT006_SubtrairMinuendoPositivoDeSubtraendoPositivoMenor()
        {
            Double minuendo = 50;
            Double subtraendo = 40;

            Double diferenca = 10;

            Double diferencaObtida = Calculadora.Subtrair(minuendo, subtraendo);

            Assert.Equal(diferenca, diferencaObtida);
        }

        [Fact]
        public void CT007_DividirDividendoPositivoPorDivisorNegativoSuperiorEmModulo()
        {
            Double dividendo = 9.87;
            Double divisor = -11;

            Double quociente = -0.8972;

            Double quocienteObtido = Calculadora.Dividir(dividendo, divisor);

            Assert.Equal(quociente, quocienteObtido);
        }

        [Fact]
        public void CT008_DividirDividendoPositivoPorDivisorPositivoMenorQue1()
        {
            Double dividendo = 2.31;
            Double divisor = 0.2;

            Double quociente = 11.55;

            Double quocienteObtido = Calculadora.Dividir(dividendo, divisor);

            Assert.Equal(quociente, quocienteObtido);
        }

        [Fact]
        public void CT009_DividirDividendoPositivoPorDivisorIgualA0()
        {
            Double dividendo = 2.31;
            Double divisor = 0;

            Assert.Throws<DivideByZeroException>(() => Calculadora.Dividir(dividendo, divisor));
        }

    }
}