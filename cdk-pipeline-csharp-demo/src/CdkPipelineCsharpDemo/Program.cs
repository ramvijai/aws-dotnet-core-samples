using Amazon.CDK;

namespace CdkPipelineCsharpDemo
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new PipelineStack(app, "PipelineStack");
            app.Synth();
        }
    }
}
