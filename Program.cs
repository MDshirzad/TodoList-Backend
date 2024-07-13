using Carter;
using TodolistBackend;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
DependencyInjection.AddTodoServices(builder.Services,builder.Configuration);

var app = builder.Build();

 
app.UseSwagger();
app.UseSwaggerUI();
app.MapCarter();
app.Run();
