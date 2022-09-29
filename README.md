# AKS-APIM Integration

### Overview
Painting company needs an application that help to know when a house paint need maintaining this application will show different customers and the location of the houses. 
The application need to log in using Azure AD also needs to provide access to their Apis to get integrated whit other applications in the future, this application needs have high availability and secure integration requirements.

### Challengue
Create AKS cluster that implement painting Api application workload, this cluster may be totally private, and cover a complete security the application have Apis to expose information for a portal and could be integrated for other applications. Azure AD will provide access to a portal and the Apis need to be validated by a secure token, Apis are exposed by a Azure Api Management to meet security and compliance requirements and for future api integration whit different providers

## Development

- NetCore
- Docker Containers

## Azure Stack

- Container Registry
- Key Vault
- Azure Kubernetes Services
- Azure API Management
- Web App
- Azure AD

## Azure Architecture

[Architecture](https://github.com/RodrigoVeraRomero/AKS-APIM-Integration/blob/main/Docs/AzureArquitecture.md "Architecture")


