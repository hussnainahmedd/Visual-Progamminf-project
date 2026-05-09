using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MindfulJournal.Components;
using MindfulJournal.Data;
using MindfulJournal.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. Database
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Identity
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>();

// 3. Add Razor Pages (required by Identity.UI package)
builder.Services.AddRazorPages();

// 4. Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddHttpContextAccessor();
// Add this line after Identity setup
builder.Services.AddScoped<MindfulJournal.Services.JournalService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

// Logout endpoint
app.MapPost("/logout", async (SignInManager<ApplicationUser> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Redirect("/login");
});

// Map Razor Pages (for Identity UI)
app.MapRazorPages();

// Blazor routing
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();