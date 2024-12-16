using AnniesCatSanctuary;
using AnniesCatSanctuary.Components;
using AnniesCatSanctuary.Services;
using Microsoft.AspNetCore.Components.Web;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlite("Data Source=Data/AnniesCatSanctuary.db"));
builder.Services.AddScoped<PetManagementService>();
builder.Services.AddScoped<PetFavoritesService>();
builder.Services.AddSingleton<PetManagementService>();
builder.Services.AddSingleton<PetFavoritesService>();

// Optional: Add HttpClient if required, for example:
builder.Services.AddHttpClient("DefaultClient", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["BaseAddress"] ?? "https://localhost:5001/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
