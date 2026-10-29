using ProgramasFacpya.Api.Common;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidationConfig();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// //Registrar DbCntext (Cnexion a la base de datos)
// builder.Services.AddSingleton<ProgramasFacpya.Api.Data.DbContext>();

// //Registrar Services
// builder.Services.AddScoped<ProgramasFacpya.Api.Features.Alumnos.AlumnoService>();

//CORS - para que el FrontEnd pueda consumir la API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}
else
{
    app.UseHttpsRedirection();
}

app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();
