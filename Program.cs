using Carter;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

 
app.UseSwagger();
app.UseSwaggerUI();

app.MapCarter();
app.Run();
