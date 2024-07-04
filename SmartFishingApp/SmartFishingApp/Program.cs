using Database.Context;
using Interfaces.UserProfile.FishingReel;
using Interfaces.UserProfile.Rod;
using Microsoft.EntityFrameworkCore;
using Services.UserProfile.FishingReel;
using Services.UserProfile.Rod;
using SmartFishingApp.Services.Implementations.FishingReelServices;
using SmartFishingApp.Services.Implementations.RodServices;
using SmartFishingApp.Services.Interfaces;
using SmartFishingApp.Services.Interfaces.IRodServices;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connection));

RegisterMappingServices(builder.Services);
RegisterSmartFishingAppServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void RegisterMappingServices(IServiceCollection services)
{
    services.AddScoped<IFishingReelMapperService, FishingReelMapperService>();
    services.AddScoped<IFishingReelTypeMapperService, FishingReelTypeMapperService>();
    services.AddScoped<IRodMapperService, RodMapperService>();
    services.AddScoped<IRodTypeMapperService, RodTypeMapperService>();
}

static void RegisterSmartFishingAppServices(IServiceCollection services)
{
    services.AddScoped<IFishingReelService, FishingReelService>();
    services.AddScoped<IFishingReelTypeService, FishingReelTypeService>();
    services.AddScoped<IRodService, RodService>();
    services.AddScoped<IRodTypeService, RodTypeService>();
}
