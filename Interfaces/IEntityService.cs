using minimalapicleanarchitecture.DTOs;

namespace minimalapicleanarchitecture.Interfaces;

public interface IEntityService
{
    Task<List<EntityDto>> GetAllEntities();
    Task<EntityDto> GetEntityById(int id);
}