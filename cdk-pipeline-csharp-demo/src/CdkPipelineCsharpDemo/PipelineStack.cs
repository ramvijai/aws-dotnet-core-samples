using Amazon.CDK;
using Amazon.CDK.AWS.CodeCommit;
using Constructs;

namespace CdkPipelineCsharpDemo
{
    public class PipelineStack : Stack
    {
        internal PipelineStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // Create a code commit repository called "DemoRepo"
            var repo = new Repository(this, "DemoRepo", new RepositoryProps
            {
                RepositoryName = "DemoRepo"
            });
        }
    }
}
