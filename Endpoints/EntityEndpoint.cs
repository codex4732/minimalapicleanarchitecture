using minimalapicleanarchitecture.Interfaces;

namespace minimalapicleanarchitecture.Endpoints;

public static class EntityEndpoint
{
    public static void MapEntityEndpoint(this WebApplication app)
    {
        app.MapGet("/GetAllEntities", async (IEntityService _entityService) => await _entityService.GetAllEntities());
    }
}