using DataAccess;
using DataAccess.Utilities;
using DataAccess.Context;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Services.Services;
using Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var reglasCORS = "ReglasCORS";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: reglasCORS,
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conectionString")));

builder.Services.AddScoped<IAreaService, AreaService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddAutoMapper(typeof(DataAccess.Utilities.MapperObj));

var app = builder.Build();  

using(var scope =  app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(reglasCORS);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
