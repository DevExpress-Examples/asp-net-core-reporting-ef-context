using DevExpress.Data.Entity;
using DevExpress.DataAccess.Web;
using System;
using Microsoft.Extensions.DependencyInjection;
namespace WebEFCoreApp.Services {
    public class CustomEFContextProviderFactory : IEFContextProviderFactory {
        private readonly IServiceProvider serviceProvider;
        public CustomEFContextProviderFactory(IServiceProvider serviceProvider) {
            this.serviceProvider = serviceProvider;
        }
        public IEFContextProvider Create() {
            return new CustomEFContextProvider(serviceProvider.CreateScope());
        }
    }
    public class CustomEFContextProvider : IEFContextProvider, IDisposable {
        private readonly IServiceScope scope;
        public CustomEFContextProvider(IServiceScope scope) {
            this.scope = scope;
        }
        
        public object GetContext(string connectionName, Type contextType) {
            // Returns the context for the specified `EFDataSource.ConnectionName`. 
            if (connectionName == "efCoreConnection")
                return scope.ServiceProvider.GetRequiredService(contextType);
            return null;
        }
        public void Dispose() {
            scope.Dispose();
        }
    }
}
