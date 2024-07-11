using Abstracciones.BW;
using Abstracciones.DA;
using BW;
using DA;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioDapper, RepositorioDapper>();

builder.Services.AddScoped<IUsuarioDA, UsuarioDA>();
builder.Services.AddScoped<IUsuarioBW, UsuarioBW>();

//builder.Services.AddScoped<ITeareaDA, TeareaDA>();
//builder.Services.AddScoped<ITeareaBW, TeareaBW>();


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
