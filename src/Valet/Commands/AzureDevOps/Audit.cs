using System.CommandLine;

namespace Valet.Commands.AzureDevOps;

public class Audit : ContainerCommand
{
    public Audit(string[] args)
        : base(args)
    {
    }

    protected override string Name => "azure-devops";
    protected override string Description => "An audit will output a list of data used in an Azure DevOps instance.";

    protected override List<Option> Options => new()
    {
        Common.Organization,
        Common.Project,
        Common.InstanceUrl,
        Common.AccessToken
    };
}