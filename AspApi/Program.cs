using MediatR;
using DataStore.Person.Data;
using DataStore.Todo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Data Access
builder.Services.AddSingleton<IPersonAccess, PersonAccess>();
builder.Services.AddMediatR(typeof(PersonAccess).Assembly);
builder.Services.AddSingleton<ITodoAccess, TodoAccess>();
builder.Services.AddMediatR(typeof(TodoAccess).Assembly);

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
