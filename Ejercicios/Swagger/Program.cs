using Data;
using Microsoft.EntityFrameworkCore;
using Infraestructure.Mapper.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityMapper();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Prueba1"), b => b.MigrationsAssembly("Data"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.Migrate();
}

// Agrega esta l�nea antes de UseEndpoints()
app.UseCors(builder => builder
    .WithOrigins("http://localhost:4200") // Reemplaza con el dominio de tu aplicaci�n Angular
    .AllowAnyHeader()
    .AllowAnyMethod()
);

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});

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
