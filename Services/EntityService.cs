using minimalapicleanarchitecture.DTOs;
using minimalapicleanarchitecture.Interfaces;

namespace minimalapicleanarchitecture.Services;

public class EntityService : IEntityService
{
    private readonly IEntityRepository _entityRepository;

    public EntityService(IEntityRepository entityRepository)
    {
        _entityRepository = entityRepository;
    }

    public async Task<List<EntityDto>> GetAllEntities() => await _entityRepository.GetAllEntities();
}