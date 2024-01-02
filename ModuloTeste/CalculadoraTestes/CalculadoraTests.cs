using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //Arrange = serve p/ montar o cenario ex: 5+10
        int num1 = 5;
        int num2 = 10;

        //Act = executa a ação somar
        int resultado = _calc.Somar(num1, num2);

        //Assert = valida se tem o resultado esperado que é o resultado 15
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10com10ERetornar20()
    {
        //Arrange = serve p/ montar o cenario ex: 5+10
        int num1 = 10;
        int num2 = 10;

        //Act = executa a ação somar
        int resultado = _calc.Somar(num1, num2);

        //Assert = valida se tem o resultado esperado que é o resultado 15
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        int numero = 4;

        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }

    //validar se os numeros 2, 4, 6, 8, 10 sao pares
//    [Theory]
//   [InlineData(2)]
//    [InlineData(4)]
//   [InlineData(6)]
//    [InlineData(8)]
//    [InlineData(10)]
//    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
//    {
        //Act
//        bool resultado = _calc.EhPar(numero);

        //Assert
//        Assert.True(resultado);
//    }




    //ou
    //validar se os numeros 2, 4, 6, 8, 10 sao pares
//    [Theory]
//    [InlineData(new int[]{2, 4})]
//    [InlineData(new int[] {6, 8, 10})]
//    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
//    {
//        foreach (var item in numeros)
//        {
//            Assert.True(_calc.EhPar(item));
//        }
//    }

//ou

    [Theory]
    [InlineData(new int[]{2, 4})]
    [InlineData(new int[] {6, 8, 10})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
       Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }

}