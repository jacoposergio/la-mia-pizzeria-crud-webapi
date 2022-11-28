using la_mia_pizzeria_static.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPizzeriaRepository, DbPizzeriaRepository>();
//builder.Services.AddScoped<IPizzeriaRepository, ListPizzeriaRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pizza}/{action=Index}/{id?}");

app.Run();
