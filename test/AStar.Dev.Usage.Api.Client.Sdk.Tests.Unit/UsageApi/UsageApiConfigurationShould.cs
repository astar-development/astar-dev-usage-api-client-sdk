using AStar.Dev.Usage.Api.Client.SDK.UsageApi;
using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Usage.Api.Client.Sdk.Tests.Unit.UsageApi;

[TestSubject(typeof(UsageApiConfiguration))]
public class UsageApiConfigurationShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new UsageApiConfiguration() { BaseUrl = new Uri("https://uri.doesnt.matter.com"), Scopes = ["Not Important"] }.ToJson().ShouldMatchApproved();
}