using FluentValidation;
using Microsoft.EntityFrameworkCore;
using minimalapicleanarchitecture.Data;
using minimalapicleanarchitecture.Endpoints;
using minimalapicleanarchitecture.ServiceConfigurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddDbContext<EntityContext>(options => options.UseInMemoryDatabase("EntityDb"));
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
