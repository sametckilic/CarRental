using CarRental.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Core.Extensions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddDependecyResolver(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }


            return ServiceTool.Create(serviceCollection);
        }

    }
}
