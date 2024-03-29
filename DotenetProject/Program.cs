using DotenetProject.Solid.Core.Repositories;
using DotenetProject.Solid.Core.Services;
using DotenetProject.Solid.Data;
using DotenetProject.Solid.Data.Repositories;
using DotenetProject.Solid.Services;
using Solid.core.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ITaxiService, TaxiService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IDriverService, DriverService>();
builder.Services.AddScoped<ITaxiRepository, TaxiRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IDriverRepository, DriverRepository>();

builder.Services.AddDbContext<DataContext>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
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