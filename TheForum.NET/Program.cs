using Microsoft.EntityFrameworkCore;
using TheForum.Data;
using Microsoft.Extensions.Configuration;
using TheForum.Data.DataLayers;
using Microsoft.AspNetCore.Identity;
using TheForum.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); // automatic razor compilation


builder.Services.AddTransient<BoardDataLayer, BoardDataLayer>();
builder.Services.AddDbContext<TheForumContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TheForumContext")), ServiceLifetime.Scoped); // connection to the Db
builder.Services.AddIdentity<ForumUser,IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<TheForumContext>();builder.Services.AddDbContext<TheForumContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TheForumContext")));

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
app.UseAuthentication(); //Identity
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
