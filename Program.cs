var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=Coworking}/{action=Space}/{id?}");
//pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "login",
    pattern: "account/login",
    defaults: new { controller = "Account", action = "Login" });
app.MapControllerRoute(
    name: "coworking",
    pattern: "coworking/index",
    defaults: new { controller = "Coworking", action = "Index" });
app.MapControllerRoute(
    name: "space",
    pattern: "coworking/space",
    defaults: new { controller = "Coworking", action = "Space" });

app.Run();
