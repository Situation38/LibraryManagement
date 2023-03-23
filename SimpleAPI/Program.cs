using Microsoft.EntityFrameworkCore;
using SimpleAPI.ConfigurationsDI;
using SimpleAPI.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//Npgsql.EnableLegacyTimestampBehavior AppContext enable legacy behavior
//To write DateTime with Kind Local to PostgreSQL type 'timestamp with time zone'
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
//Injections
builder.Services.AddCoreServices(builder.Configuration);
builder.Services.AddInfrastructureServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
