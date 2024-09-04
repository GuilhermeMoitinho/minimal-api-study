namespace native_aot.Extensions;

internal static class Startup
{
    internal static WebApplicationBuilder AddApiConfig(this WebApplicationBuilder builder)
    {
        builder.Services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions.TypeInfoResolver = ResolveJson.Default;
        });

        builder.Services.AddCors(o => o.AddPolicy("PoliceMoita", builder =>
        {
            builder.WithOrigins("http://localhost")
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }));

        return builder;
    }

    internal static WebApplication AddUseApiConfig(this WebApplication app)
    {
        app.UseCors("PoliceMoita");
        app.Run();

        return app;
    }
}
