using System.Security.Cryptography.X509Certificates;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using minimalapicleanarchitecture.Data;
using minimalapicleanarchitecture.DTOs;
using minimalapicleanarchitecture.Interfaces;
using minimalapicleanarchitecture.Model;

namespace minimalapicleanarchitecture.Repositories;

public class EntityRepository : IEntityRepository
{
    private readonly EntityContext _context;

    public EntityRepository(EntityContext context)
    {
        _context = context;
    }

    public async Task<List<EntityDto>> GetAllEntities() => (await _context.Entities.Where(x => x.Status != "D")
        .Join(_context.Countries, entity => entity.CountryId, country => country.Id,
                (entity, country) => new { entity, country })
        .Select(x => new
        {
            x.entity.Id,
            x.entity.FirstName,
            x.entity.LastName,
            x.entity.Address1,
            x.entity.Email,
            CountryName = x.country.Name,
            x.entity.Phone
        })
        .ToListAsync()).Adapt<List<EntityDto>>();

    public async Task<EntityDto> GetEntityById(int id) => (await _context.Entities.Where(x => x.Status != "D" && x.Id == id).Join(_context.Countries, entity => entity.CountryId, country => country.Id, (entity, country) => new { entity, country }).Select(x => new
    {
        x.entity.Id,
        x.entity.FirstName,
        x.entity.LastName,
        x.entity.Address1,
        x.entity.Email,
        CountryName = x.country.Name,
        x.entity.Phone
    }).FirstOrDefaultAsync()).Adapt<EntityDto>();
}