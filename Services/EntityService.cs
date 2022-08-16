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

    public async Task<EntityDto> GetEntityById(int id)
    {
        if (id < 0 || id == 0)
            throw new ArgumentException("Id cannot be negative or zero");

        return await _entityRepository.GetEntityById(id);
    }
}