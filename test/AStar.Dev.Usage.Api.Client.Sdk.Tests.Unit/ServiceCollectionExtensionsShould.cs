using AStar.Dev.Usage.Api.Client.SDK;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AStar.Dev.Usage.Api.Client.Sdk.Tests.Unit;

[TestSubject(typeof(ServiceCollectionExtensions))]
public class ServiceCollectionExtensionsShould
{

    [Fact]
    public void AddTheExpectedServices()
    {

        var configurationManager = new ConfigurationManager();
        var sut                  = new ServiceCollection();

        _ = sut.AddApiConfiguration(configurationManager);

        sut.Count.ShouldBe(7);
    }
}