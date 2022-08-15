using Microsoft.EntityFrameworkCore;
using minimalapicleanarchitecture.Data;
using minimalapicleanarchitecture.Interfaces;
using minimalapicleanarchitecture.Repositories;

namespace minimalapicleanarchitecture.ServiceConfigurations;

public static class ServiceExtension
{
    public static void AddInfrastructureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IEntityRepository, EntityRepository>();
    }
}