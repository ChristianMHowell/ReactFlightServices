

namespace ReactFlightServices.Utilities
{
    public static class EndpointExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="scanMarkers"></param>
        public static void AddServices(this IServiceCollection services, params Type[] scanMarkers)
        {
            var endpointExtensions = new List<IEndpointExtensions>();
            foreach (var scanMarker in scanMarkers)
            {
                endpointExtensions.AddRange(scanMarker.Assembly.ExportedTypes
                                            .Where(x => typeof(IEndpointExtensions).IsAssignableFrom(x) && !x.IsInterface)
                                            .Select(Activator.CreateInstance).Cast<IEndpointExtensions>());
            }

            foreach (var endpointExtension in endpointExtensions)
                endpointExtension.DefineServices(services);

            services.AddSingleton(endpointExtensions as IReadOnlyCollection<IEndpointExtensions>);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public static void UseEnpointDefinitions(this WebApplication app)
        {
            var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpointExtensions>>();
            
            foreach (var definition in definitions)
                definition.DefineEndpoints(app);
        }
    }
}
