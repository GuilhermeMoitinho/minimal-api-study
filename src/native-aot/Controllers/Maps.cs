using native_aot.Models;
using native_aot.Repositories.Interfaces;

namespace native_aot.Controllers;

internal static class Maps
{
    internal static WebApplication AddMaps(this WebApplication app)
    {
        var peaplesRoute = app.MapGroup("peaples");

        peaplesRoute.MapGet("/", (IPeapleRepository peapleRepository) => 
                   peapleRepository.GetAllPeaples() is { } peaples
                 ? Results.Ok(peaples)
                 : Results.NotFound());

        peaplesRoute.MapGet("/{id}", (Guid id, IPeapleRepository peapleRepository) =>
                  peapleRepository.GetPeaple(id) is { } peaple
                ? Results.Ok(peaple)
                : Results.NotFound());

        peaplesRoute.MapPost("/", (Peaple peaple, IPeapleRepository peapleRepository) =>
                  peapleRepository.AddPeaple(peaple));
                  Results.Created();

        peaplesRoute.MapPut("/{id}", (Peaple peaple, Guid id, IPeapleRepository peapleRepository) =>
                  peapleRepository.UpdatePeaple(id, peaple));
                  Results.NoContent();

        peaplesRoute.MapDelete("/{id}", (Guid id, IPeapleRepository peapleRepository) =>
                  peapleRepository.DeletePeaple(id));
                  Results.NoContent();

        return app;
    }
}
