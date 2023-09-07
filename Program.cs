using entityframework_postgresql.Models.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ApplicationContext>(contextOptions => contextOptions.UseNpgsql("host=localhost port=5432 dbname=entityframework user=entity password=microsoft sslmode=prefer sslcompression=0 connect_timeout=30"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
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

app.Run();
