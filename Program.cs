using Microsoft.EntityFrameworkCore;
using PokemonApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options=>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/pokemon", async (AppDbContext context) =>
{
   var pokemons = await context.Pokemon.ToListAsync();
    if (pokemons.Count == 0) return Results.NotFound("Dados não encontrados");
    return Results.Ok(await context.Pokemon.ToListAsync()); 
});

app.Run();
