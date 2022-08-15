using minimalapicleanarchitecture.Interfaces;
using minimalapicleanarchitecture.Services;

namespace minimalapicleanarchitecture.ServiceConfigurations;

public static class ApplicationServiceExtension
{
    public static void AddApplicationServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IEntityService, EntityService>();
    }
}