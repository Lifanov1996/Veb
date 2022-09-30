using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;
using WebApplication1.Data;
using WebApplication1.AccountUser;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<EntityData>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddTransient<IClient, ClientOptional>();

builder.Services.AddMvc();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<EntityData>()
//    .AddDefaultTokenProviders();

builder.Services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<EntityData>()
                .AddDefaultTokenProviders();


builder.Services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequiredLength = 6;
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(5);
            options.Lockout.AllowedForNewUsers = true;
        });

//builder.Services.ConfigureApplicationCookie(options =>
//        {
//            options.Cookie.HttpOnly = true;
//            options.ExpireTimeSpan = TimeSpan.FromSeconds(5);
//            options.LoginPath = "/Account/Login";
//            options.LogoutPath = "/Account/Logout";
//            options.AccessDeniedPath = "/";
//            options.SlidingExpiration = true;
//        });



builder.Services.AddRazorPages();


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

app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
