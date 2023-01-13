using Microsoft.EntityFrameworkCore;
using Portside.Persistance.DbContext;
using PortsideUi.MapperProfile;
using PortsideUi.Services;
using PortsideUi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAutoMapper(typeof(CustomerProfile), typeof(ReservationProfile));


var connection = builder.Configuration.GetConnectionString("WinAuth");
builder.Services.AddDbContext<DataBaseContext>(options  => options .UseSqlServer(connection));
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IReservationService, ReservationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
