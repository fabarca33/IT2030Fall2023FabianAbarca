using Microsoft.EntityFrameworkCore;
using FabianMusic.Models.Data;

var builder = WebApplication.CreateBuilder(args);

//must be called before AddControllersWithViews()
builder.Services.AddMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
    options.Cookie.IsEssential = true;
});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FabianMusicContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FabianMusicContext")
    ?? throw new InvalidOperationException("Connection string 'FabianMusicContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// must be called before routes are mapped
app.UseSession();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

