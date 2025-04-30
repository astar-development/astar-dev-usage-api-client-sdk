using AStar.Dev.Usage.Api.Client.SDK;
using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Usage.Api.Client.Sdk.Tests.Unit;

[TestSubject(typeof(ApiUsageConfiguration))]
public class ApiUsageConfigurationShould
{
    [Fact]
    public void ContainTheExpectedConfigurationProperties()
    => new ApiUsageConfiguration(){ HostName = "Host Doesnt Matter", Password = "You won't find it here...", QueueName = "Some Queue Name", UserName = "Username doesnt matter"}.ToJson().ShouldMatchApproved();
}