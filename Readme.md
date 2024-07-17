<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/648247158/23.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1169488)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-reporting-ef-context&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-reporting-ef-context&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
