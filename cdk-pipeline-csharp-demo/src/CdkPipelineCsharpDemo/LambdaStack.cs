using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.APIGateway;
using Constructs;

namespace CdkPipelineCsharpDemo
{
    public class LambdaStack : Stack
    {
        internal LambdaStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // Defines a new Lambda resource
            var hello = new Function(this, "HelloHandler", new FunctionProps()
            {
                Runtime = Runtime.NODEJS_14_X, //execution environment
                Code = Code.FromAsset("lambda"), //Code loaded from the lambda" directory
                Handler = "hello.handler" //file is "hello", function is "handler"
            });

            // Defines an API gateway REST API resource backed by our "hello" function
            new LambdaRestApi(this, "Endpoint", new LambdaRestApiProps()
            {
                Handler = hello
            });
        }
    }
}

