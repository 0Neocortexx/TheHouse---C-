using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Profiles.Compras;
using Model.Profiles.MetaProfile;
using Model.Profiles.UsuarioProfile;
using Model.Profiles.VisitaProfile;
using Model.Repositories.Compras;
using Model.Repositories.Entretenimento;
using Model.Repositories.MetaRepository;
using Model.Repositories.UsuarioRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddControllersWithViews();

// Configurar a conexão com o banco de dados PostgreSQL

builder.Services.AddControllers();
builder.Services.AddDbContext<TheHouseContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IVisitaRepository,VisitaRepository>();

// Registro de Repositorys
builder.Services.AddTransient<IComprasRepository, ComprasRepository>();
builder.Services.AddTransient<IVisitaRepository, VisitaRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<IMetaRepository, MetaRepository>();

// Registro de Mappers
builder.Services.AddAutoMapper(typeof(UsuarioProfile).Assembly);
builder.Services.AddAutoMapper(typeof(ComprasProfile).Assembly);
builder.Services.AddAutoMapper(typeof(VisitaProfile).Assembly);
builder.Services.AddAutoMapper(typeof(MetaProfile).Assembly);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:5173");
        });
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseCors();

// Roda a aplicação
app.Run();
