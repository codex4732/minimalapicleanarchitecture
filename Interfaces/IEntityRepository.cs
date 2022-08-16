using minimalapicleanarchitecture.DTOs;

namespace minimalapicleanarchitecture.Interfaces;

public interface IEntityRepository
{
    Task<List<EntityDto>> GetAllEntities();
    Task<EntityDto> GetEntityById(int id);
}