using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Repositories.Compras;
using Model.Repositories.Entretenimento;
using Model.Repositories.UsuarioRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddControllersWithViews();

// Configurar a conexão com o banco de dados PostgreSQL

builder.Services.AddControllers();
builder.Services.AddDbContext<TheHouseContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IVisitasRepository,VisitasRepository>();


builder.Services.AddTransient<IComprasRepository, ComprasRepository>();
builder.Services.AddTransient<IVisitasRepository, VisitasRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

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

// Roda a aplicação
app.Run();
