# Azure Arquitecture

This architecture is based on the AKS Baseline architecture that Microsoft's recommended as starting point for AKS infrastructure
https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/containers/aks/baseline-aks

This basiline architecture is implemented following this documentation 
[Architecture](https://github.com/RodrigoVeraRomero/AKS-Private "Architecture") 

### Diagram

<img src="https://github.com/RodrigoVeraRomero/AKS-APIM-Integration/blob/main/Docs/Architecture.png" width="385px" align="center">

There are 4 aditional components compared to the baseline, that are using on this exercice to meet requirements.

### Container Registry
This component allows to build, store and manage container images, container registry is used store application apis and portal. 
https://learn.microsoft.com/en-us/azure/container-registry/

### Asure API Management
Azure API Management is a hybrid, multicloud management platform for APIs across all environments, for this excercies needs and API Management for future aplication integration or new api providers.
https://learn.microsoft.com/en-us/azure/api-management/api-management-key-concepts

### WEB App
Azure App Service is an HTTP-based service for hosting web applications, for an example portal decided to have web app aplication that provide full cloud integration
https://learn.microsoft.com/en-us/azure/app-service/overview

### Azure AD
Azure Active Directory (Azure AD) is a cloud-based identity and access management service. This service provide components necesaries to meet authentication and authorization validation for apis and for a portal
https://learn.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-whatis

## Example Aplication

Example aplication is this repositorio de solution DemoAKSAPIM.sln contains 4 proyects

* ApiPerson. This is an API implementation to get all people register on the application that need painting house monitoring, the api is a net core aplication and will live on AKS cluster.

* ApiAdress. This is an API implementation to get all adreses of customer register on the application that need painting house monitoring, the api is a net core aplication and will live on AKS cluster.

* ApiPaintHouse. This is an API implementation to get all the status exterior and interior paint house that provide information of meters and quality percentaje painting, the api is a net core aplication and will live on AKS cluster.

* PaintPortal. This is an example portal build on net core that get information from the apis and 