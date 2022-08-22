using minimalapicleanarchitecture.Interfaces;

namespace minimalapicleanarchitecture.Endpoints;

public static class EntityEndpoint
{
    public static void MapEntityEndpoint(this WebApplication app)
    {
        app.MapGet("/GetAllEntities", async (IEntityService _entityService) => await _entityService.GetAllEntities());
        app.MapGet("/GetEntityById/{id}", async (IEntityService _entityService, int id) => await _entityService.GetEntityById(id));

        app.MapGet("/GenerateError", () => {
            try
            {
                throw new Exception("This is a test exception");
            }
            catch (System.Exception)
            {
                throw;
            }
        });
    }
}