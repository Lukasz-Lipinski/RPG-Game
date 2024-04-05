global using AutoMapper;
global using myRPG.DB;
global using myRPG.Dtos.Mechanisms;
global using myRPG.Dtos.Monster;
global using myRPG.Dtos.Player;
global using myRPG.Dtos.Schemas;
global using myRPG.Services.MonsterServices;
global using myRPG.Services.PlayerServices;
using myRPG.Services.BattleGeneratorService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IMonsterService, MonsterService>();
builder.Services.AddScoped<IBattleRaportGeneratorService, BattleRaportGeneratorService>();

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
