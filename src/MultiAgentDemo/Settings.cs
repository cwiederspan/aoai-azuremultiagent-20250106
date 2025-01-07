using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace MultiAgentDemo;

public class Settings {

    private readonly IConfigurationRoot configRoot;

    public AzureOpenAISettings AzureOpenAI { 
        get {
            return this.GetSettings<Settings.AzureOpenAISettings>();
        } 
    }

    public class AzureOpenAISettings {
        public string ChatModelDeployment { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
    }

    public TSettings GetSettings<TSettings>() =>
        this.configRoot.GetRequiredSection(typeof(TSettings).Name).Get<TSettings>()!;

    public Settings() {
        this.configRoot =
            new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddUserSecrets(Assembly.GetExecutingAssembly(), optional: true)
                .Build();
    }
}