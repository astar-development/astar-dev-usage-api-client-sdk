using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AStar.Dev.Usage.Api.Client.SDK;

/// <summary>
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configurationManager"></param>
    /// <returns></returns>
    public static IServiceCollection AddApiConfiguration(this IServiceCollection services, ConfigurationManager configurationManager)
    {
        _ = services
            .AddOptions<ApiUsageConfiguration>()
            .Bind(configurationManager.GetSection(ApiUsageConfiguration.ConfigurationSectionName));

        return services;
    }
}