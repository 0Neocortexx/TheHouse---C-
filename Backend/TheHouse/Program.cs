using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model.Context;
using Model.Profiles.Compras;
using Model.Profiles.MetaProfile;
using Model.Profiles.UsuarioProfile;
using Model.Profiles.VisitaProfile;
using Model.Repositories.Compras;
using Model.Repositories.Entretenimento;
using Model.Repositories.Interfaces;
using Model.Repositories.MetaRepository;
using Model.Repositories.UsuarioRepository;
using Model.Services.CompraService;
using Model.Services.Interfaces;
using Model.Services.MetaService;
using Model.Services.UsuarioService;
using Model.Services.VisitaService;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<TheHouseContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


//// Registro de Repositorys
builder.Services.AddTransient<ICompraRepository, CompraRepository>();
builder.Services.AddTransient<IVisitaRepository, VisitasRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<IMetaRepository, MetaRepository>();

// Registro de Services
builder.Services.AddScoped<IMetaService, MetaService>();
builder.Services.AddScoped<ICompraService, CompraService>();
builder.Services.AddScoped<IVisitaService, VisitaService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

// Registro de Mappers
builder.Services.AddAutoMapper(typeof(UsuarioProfile).Assembly);
builder.Services.AddAutoMapper(typeof(CompraProfile).Assembly);
builder.Services.AddAutoMapper(typeof(VisitaProfile).Assembly);
builder.Services.AddAutoMapper(typeof(MetaProfile).Assembly);

// Inserindo o crossorigin
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:5173");
        });
});

// Adicionar serviços de autenticação JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("TheHouseTokenSuperSecretKeyMaster2024")),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // Ativa a autenticaçã
app.UseAuthorization();
app.UseCors();


app.MapControllers();

app.Run();
