# Reporting for ASP.NET Core - Resolve the Entity Framework Core Context from the DI Container

The following example obtains Entity Framework Core context from an ASP.NET Core dependency injection container.

1. Implement the [IEFContextProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Entity.IEFContextProvider?v=23.1&p=netframework) and [IEFContextProviderFactory](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IEFContextProviderFactory?v=23.1&p=netframework) interfaces (`CustomEFContextProvider` and `CustomEFContextProviderFactory` classes in this example) to create a service that allows you to obtain EF Core Context.

2. Register the context in the dependency injection container. Call the [AddDbContext](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.entityframeworkservicecollectionextensions.adddbcontext?view=efcore-7.0) method in the `ConfigureServices` method of the `Startup` class to specify the required connection string. 

3. Use the `ConfigureServices` method of the `Startup` class to register the factory implementation.

## Files to Review

- [Startup.cs](./WebEFCoreApp/Startup.cs)
- [CustomEFContextProviderFactory.cs](./WebEFCoreApp/Services/CustomEFContextProviderFactory.cs)

## Documentation

- [IEFContextProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Entity.IEFContextProvider?v=23.1&p=netframework)
- [IEFContextProviderFactory](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Web.IEFContextProviderFactory?v=23.1&p=netframework)