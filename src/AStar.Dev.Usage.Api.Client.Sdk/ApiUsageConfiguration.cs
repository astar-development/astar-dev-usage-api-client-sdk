namespace AStar.Dev.Usage.Api.Client.SDK;

/// <summary>
/// </summary>
public class ApiUsageConfiguration
{
    /// <summary>
    /// </summary>
    public static string ConfigurationSectionName => "ApiUsageConfiguration";

    /// <summary></summary>
    public required string HostName { get; init; }

    /// <summary></summary>
    public required string UserName { get; init; }

    /// <summary></summary>
    public required string Password { get; init; }

    /// <summary></summary>
    public required string QueueName { get; init; }
}