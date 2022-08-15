using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using minimalapicleanarchitecture.Data;
using minimalapicleanarchitecture.Endpoints;
using minimalapicleanarchitecture.ServiceConfigurations;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkInMemoryDatabase();
builder.Services.AddDbContext<EntityContext>( options => options.UseSqlServer(builder.Configuration.GetSection("EntityDbConnection").Value));
builder.AddInfrastructureServices();
builder.AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Add Endpoints
app.MapEntityEndpoint();

app.UseHttpsRedirection();



app.Run();
