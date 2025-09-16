using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pedidos_view.Data;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Configura��o de localiza��o (pt-BR)
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("pt-BR");
    options.SupportedCultures = new List<CultureInfo>
    {
        new CultureInfo("pt-BR")
    };
    options.SupportedUICultures = options.SupportedCultures;
});

// MVC
builder.Services.AddControllersWithViews();

// Banco de dados (MariaDB)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MariaDBConnection"),
        new MariaDbServerVersion(new Version(11, 5, 2))
    )
);

var app = builder.Build();

// Configura��es para ambiente de produ��o
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Middlewares principais
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Rotas padr�o
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pedidos}/{action=Index}/{id?}"
);

app.Run();
