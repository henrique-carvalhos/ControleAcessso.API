using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Implementations;
using ControleAcessso.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ControleAcessoDbContext>();

builder.Services.AddScoped<IGrupoRelatorioService, GrupoRelatorioService>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRelatorioService,RelatorioService>();

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
