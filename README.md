<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/648247158/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1169488)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Reporting for ASP.NET Core - Resolve the Entity Framework Core Context from the DI Container

The following example shows how to obtain the Entity Framework Core context from the ASP.NET Core dependency injection container.

1. Implement the [IEFContextProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Entity.IEFContextProvider?v=23.1&p=netframework) and [IEFContextProviderFactory](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IEFContextProviderFactory?v=23.1&p=netframework) interfaces (the `CustomEFContextProvider` and `CustomEFContextProviderFactory` classes in this example) to create a service that allows you to get the EF Core Context.

2. Register the context in the dependency injection container. Call the [AddDbContext](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.entityframeworkservicecollectionextensions.adddbcontext?view=efcore-7.0) method in the `ConfigureServices` method of the `Startup` class to specify the required connection string. 

3. Use the `ConfigureServices` method of the `Startup` class to register the factory implementation.

## Files to Review

- [Startup.cs](./WebEFCoreApp/Startup.cs)
- [CustomEFContextProviderFactory.cs](./WebEFCoreApp/Services/CustomEFContextProviderFactory.cs)

## Documentation

- [IEFContextProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Entity.IEFContextProvider?v=23.1&p=netframework)
- [IEFContextProviderFactory](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IEFContextProviderFactory?v=23.1&p=netframework)
