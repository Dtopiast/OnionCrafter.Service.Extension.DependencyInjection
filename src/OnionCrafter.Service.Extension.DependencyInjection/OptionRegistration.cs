using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OnionCrafter.Service.Extension.DependencyInjection.Exceptions;
using OnionCrafter.Service.Option.Base;

namespace OnionCrafter.Service.Extension.DependencyInjection
{
    /// <summary>
    /// Extension methods for the service registration.
    /// </summary>
    public static class OptionRegistration
    {
        /// <summary>
        /// Adds typed options of the specified type to the service collection.
        /// </summary>
        /// <typeparam name="TOptions">The type of options to configure.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <param name="configure">The action to configure the options.</param>
        /// <returns>The <see cref="IServiceCollection"/> after the services have been added.</returns>
        /// <exception cref="ImplementedOptionException">Thrown when an option with the same name has already been registered.</exception>
        public static IServiceCollection AddTypedOptions<TOptions>(this IServiceCollection services, Action<TOptions> configure)
            where TOptions : class, IBaseOptions
        {
            services.AddTypedOptions(configure, typeof(TOptions).Name);
            return services;
        }

        /// <summary>
        /// Adds typed options of the specified type to the service collection with a custom implementation name.
        /// </summary>
        /// <typeparam name="TOptions">The type of options to configure.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <param name="configure">The action to configure the options.</param>
        /// <param name="implementationName">The custom implementation name for the options.</param>
        /// <returns>The <see cref="IServiceCollection"/> after the services have been added.</returns>
        /// <exception cref="ImplementedOptionException">Thrown when an option with the same name has already been registered.</exception>
        public static IServiceCollection AddTypedOptions<TOptions>(this IServiceCollection services, Action<TOptions> configure, string implementationName)
            where TOptions : class, IBaseOptions
        {
            TOptions options = Activator.CreateInstance<TOptions>();
            configure.Invoke(options);
            string serviceName = options is ISetName setNameOptions ? setNameOptions.SetName ?? implementationName : implementationName;
            if (services.Any(x => x.ImplementationType == typeof(IOptions<TOptions>) && x.ImplementationInstance is IOptions<ISetName> option && option.Value.SetName == serviceName))
                throw new ImplementedOptionException(serviceName);
            services.AddOptions<TOptions>(serviceName).Configure(configure);
            return services;
        }
    }
}