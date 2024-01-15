using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.SystemTextJson;

[assembly: LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]

namespace hello_world_lambda_csharp
{
    public class Function
    {
        public string Handler(MyEvent input, ILambdaContext context)
        {
            return "Hello World";
        }
    }

    public class MyEvent
    {
        public string Propriedade1 { get; set; } = null;
    }

}
