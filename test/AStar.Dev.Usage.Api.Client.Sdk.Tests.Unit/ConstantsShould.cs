using AStar.Dev.Usage.Api.Client.SDK;
using JetBrains.Annotations;

namespace AStar.Dev.Usage.Api.Client.Sdk.Tests.Unit;

[TestSubject(typeof(Constants))]
public class ConstantsShould
{
    [Fact]
    public void ContainTheApiNamePropertyWithTheExpectedValue()
        => Constants.ApiName.ShouldBe("AStar.Dev.Usage.Api");
}