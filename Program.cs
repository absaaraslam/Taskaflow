using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagementProject.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DBTaskManagementContextSampleConnection") ?? throw new InvalidOperationException("Connection string 'DBTaskManagementContextSampleConnection' not found.");

builder.Services.AddDbContext<DBTaskManagementContextSample>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<TaskManagementProject.Models.TaskManagementDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<TaskManagementProjectUser>().AddEntityFrameworkStores<DBTaskManagementContextSample>();

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
	var policy = new AuthorizationPolicyBuilder()
		.RequireAuthenticatedUser() // Require users to be logged in
		.Build();

	options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()); // Add CSRF protection
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
