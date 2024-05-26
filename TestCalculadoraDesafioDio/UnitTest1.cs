using CalculadoraDesafioDio;

namespace TestCalculadoraDesafioDio
{
    public class UnitTest1
    {   //Ao usarmos o Theory, podemos utilizar o InlineData e não precisamos copiar e colar o teste, apenas reutilizar o InlineData
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int value1, int value2, int resultado)
        {   //adicionar projectReference + projPrincipal; adicionar o using;
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.somar(value1, value2);

            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(4, 1, 3)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int value1, int value2, int resultado)
        {   //adicionar projectReference + projPrincipal; adicionar o using;
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.subtrair(value1, value2);

            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int value1, int value2, int resultado)
        {   //adicionar projectReference + projPrincipal; adicionar o using;
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.multiplicar(value1, value2);

            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(45, 5, 9)]
        public void TesteDividir(int value1, int value2, int resultado)
        {   //adicionar projectReference + projPrincipal; adicionar o using;
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.dividir(value1, value2);

            Assert.Equal(resultadoCalculadora, resultado);
        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));

        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(2, 3);
            calc.somar(3, 4);
            calc.somar(4, 5);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}