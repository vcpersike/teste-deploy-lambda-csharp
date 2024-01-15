using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using hello_world_lambda_csharp; // Certifique-se de importar o namespace correto

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {
        // Cria uma instância da função Lambda
        var function = new Function();
        var context = new TestLambdaContext();

        // Cria um objeto MyEvent para passar para a função Lambda
        var myEvent = new MyEvent
        {
            Propriedade1 = "valor de teste"
        };

        // Invoca a função Lambda e confirma a resposta
        var response = function.Handler(myEvent, context);

        // Como o retorno esperado é "Hello World", o teste deve refletir isso
        Assert.Equal("Hello World", response);
    }
}
