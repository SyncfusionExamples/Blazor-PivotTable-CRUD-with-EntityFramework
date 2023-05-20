using Syncfusion.Blazor;
using MyBlazorApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSyncfusionBlazor();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR(e => { e.MaximumReceiveMessageSize = 102400000; });
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<OrderDataAccessLayer>();
builder.Services.AddScoped<HttpClient>(factory => new HttpClient(new HttpClientHandler()
{
    ServerCertificateCustomValidationCallback = (HttpRequestMessage m, System.Security.Cryptography.X509Certificates.X509Certificate2 f, System.Security.Cryptography.X509Certificates.X509Chain x, System.Net.Security.SslPolicyErrors d) => true
}));
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

// Adds endpoints for controller actions to the Microsoft.AspNetCore.Routing.IEndpointRouteBuilder
app.MapDefaultControllerRoute();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
