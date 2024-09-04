using native_aot.DataContext;
using native_aot.Repositories;
using native_aot.Repositories.Interfaces;

namespace native_aot.Extensions;

internal static class DependencyInjection
{
    internal static WebApplicationBuilder AddInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IPeapleRepository, PeapleRepository>();
        builder.Services.AddSingleton<IDataContext, DataContext.DataContext>();


        return builder;
    }
}
