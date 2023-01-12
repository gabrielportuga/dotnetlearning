using Microsoft.EntityFrameworkCore;
using users.domain.repository;
using users.infrastructure.repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddDbContext<RepositoryContext>(opts =>
               opts.UseNpgsql(builder.Configuration.GetConnectionString("UserDbPostgres"), b => b.MigrationsAssembly("usersdb")));
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();



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
