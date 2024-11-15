using InfraTheHouse.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabase(builder.Configuration); // Adicionando configurações de Database
builder.Services.AddRepositories(); // Registro de Repositorys
builder.Services.AddServices(); // Registro de Services
builder.Services.AddMappers(); // Registro de Mappers
builder.Services.AddCorsPolicy(); // Inserindo o crossorigin
builder.Services.AddJwtAuthentication(builder.Configuration); // Adicionar serviços de autenticação JWT
builder.Services.AddControllers(); // Adicionando controllers
builder.Services.AddSwaggerGen(); // Inserindo o swagger

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins"); // Ativa o CORS
app.UseAuthentication(); // Ativa a autenticaçã
app.UseAuthorization(); // Ativa a autorização 
app.MapControllers();

app.Run();
