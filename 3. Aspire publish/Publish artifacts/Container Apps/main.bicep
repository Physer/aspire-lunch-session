targetScope = 'subscription'

param resourceGroupName string

param location string

param principalId string

resource rg 'Microsoft.Resources/resourceGroups@2023-07-01' = {
  name: resourceGroupName
  location: location
}

module aspire_env 'aspire-env/aspire-env.bicep' = {
  name: 'aspire-env'
  scope: rg
  params: {
    location: location
    userPrincipalId: principalId
  }
}

output aspire_env_AZURE_CONTAINER_REGISTRY_NAME string = aspire_env.outputs.AZURE_CONTAINER_REGISTRY_NAME

output aspire_env_AZURE_CONTAINER_REGISTRY_ENDPOINT string = aspire_env.outputs.AZURE_CONTAINER_REGISTRY_ENDPOINT

output aspire_env_AZURE_CONTAINER_REGISTRY_MANAGED_IDENTITY_ID string = aspire_env.outputs.AZURE_CONTAINER_REGISTRY_MANAGED_IDENTITY_ID

output aspire_env_AZURE_CONTAINER_APPS_ENVIRONMENT_DEFAULT_DOMAIN string = aspire_env.outputs.AZURE_CONTAINER_APPS_ENVIRONMENT_DEFAULT_DOMAIN

output aspire_env_AZURE_CONTAINER_APPS_ENVIRONMENT_ID string = aspire_env.outputs.AZURE_CONTAINER_APPS_ENVIRONMENT_ID