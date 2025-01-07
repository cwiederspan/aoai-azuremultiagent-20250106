# Azure OpenAI + Semantic Kernel Multi-Agent Demo

A multi-agent demo using Semantic Kernel and Azure OpenAI. Based on this [GitHub Repo](https://learn.microsoft.com/en-us/semantic-kernel/frameworks/agent/examples/example-agent-collaboration?pivots=programming-language-csharp).

```bash

# Create the project
dotnet new console -o src/MultiAgentDemo -n MyMultiAgentDemo

# dotnet new sln -n MySolution

# Get into the new project directory
cd src/MyMultiAgentDemo

# Add the necessary packages
dotnet add package Azure.Identity
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Binder
dotnet add package Microsoft.Extensions.Configuration.UserSecrets
dotnet add package Microsoft.Extensions.Configuration.EnvironmentVariables
dotnet add package Microsoft.SemanticKernel.Connectors.AzureOpenAI
dotnet add package Microsoft.SemanticKernel.Agents.Core --prerelease

# Load the secrets and ENV variables
source ../../.env

# Azure Open AI
dotnet user-secrets set "AzureOpenAISettings:ApiKey" "<api-key>" # Not required if using token-credential
dotnet user-secrets set "AzureOpenAISettings:Endpoint" "<model-endpoint>"
dotnet user-secrets set "AzureOpenAISettings:ChatModelDeployment" "gpt-4o"

```
