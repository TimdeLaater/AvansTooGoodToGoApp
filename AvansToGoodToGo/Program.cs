using Microsoft.AspNetCore.Identity;
using System.Security;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DomainServices;
using Infrastructure.Data;
using DomainModel.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews();

//EF 
builder.Services.AddDbContext<FoodDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("Default")));

//ID Framework


builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<FoodDBContext>()
    .AddDefaultTokenProviders();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)//Adds Cookies
    .AddCookie();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("OnlyPowerUsersAndUp", policy => policy
        .RequireAuthenticatedUser()
        .RequireClaim("UserType", "poweruser"));

    options.AddPolicy("OnlyRegularUsersAndUp", policy => policy
        .RequireAuthenticatedUser()
        .RequireClaim("UserType", "regularuser", "poweruser"));
});

//DI
builder.Services.AddScoped<IProductRepo, SQLProductRepo>();
builder.Services.AddScoped<IPackageRepo, SQLPackageRepo>();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential 
    // cookies is needed for a given request.
    options.CheckConsentNeeded = context => true;

    options.MinimumSameSitePolicy = SameSiteMode.None;
});







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
app.UseCookiePolicy();
app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
