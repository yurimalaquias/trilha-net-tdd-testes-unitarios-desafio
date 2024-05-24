using tddnetcore;

namespace Testtddnetcore
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "24/05/2024";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void DeveSomar1com1ERetornar2(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(10, 4, 6)]
        public void DeveSubtrair3com2ERetornar1(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 20)]
        public void DeveMultiplicar2com2ERetornar4(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(10, 2, 5)]
        public void DeveDividir9por3ERetornar3(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(1, 2);
            calc.somar(3, 4);
            calc.somar(5, 6);
            calc.somar(7, 8);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}