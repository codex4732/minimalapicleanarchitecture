using Bogus;
using Microsoft.EntityFrameworkCore;
using minimalapicleanarchitecture.Model;

namespace minimalapicleanarchitecture.Data;

public class EntityContext : DbContext
{
    public DbSet<Country>? Countries { get; set; }
    public DbSet<Entity>? Entities { get; set; }

    public EntityContext(DbContextOptions<EntityContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {
        base.OnModelCreating(modelBuilder);

        var EntityIds = 1;
        var entityData = new Faker<Entity>()
            .RuleFor(m => m.Id, f => EntityIds++)
            .RuleFor(m => m.FirstName, f => f.Name.FirstName())
            .RuleFor(m => m.LastName, f => f.Name.LastName())
            .RuleFor(m => m.Email, f => f.Internet.Email())
            .RuleFor(m => m.Phone, f => f.Phone.PhoneNumber())
            .RuleFor(m => m.Address1, f => f.Address.StreetAddress())
            .RuleFor(m => m.CountryId, f => f.Random.Int(1, 20))
            .RuleFor(m => m.Status, f => f.Random.String2(1,"I"))
            .RuleFor(m => m.DtAccess, f => f.Date.Past())
            .RuleFor(m => m.UserId, f => f.Random.Int(1, 20));

        var CountryIds = 1;
        var countryData = new Faker<Country>()
            .RuleFor(m => m.Id, f => CountryIds++)
            .RuleFor(m => m.Code, f => f.Address.CountryCode())
            .RuleFor(m => m.Name, f => f.Address.Country())
            .RuleFor(m => m.Status, f => f.Random.String2(1, "I"))
            .RuleFor(m => m.DtAccess, f => f.Date.Past())
            .RuleFor(m => m.UserId, f => f.Random.Int(1, 20));

        // Generate fake data for entity table
        modelBuilder.Entity<Entity>().HasData(entityData.Generate(100));

        // Generate fake data for country table
        modelBuilder.Entity<Country>().HasData(countryData.Generate(100));
    }
}