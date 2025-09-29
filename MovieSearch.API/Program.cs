using MovieSearch.Application.Interfaces;
using MovieSearch.Application.Services;
using MovieSearch.Infrastructure.Clients;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("https://moviessearchfe-a4bjdgb3hsfnc0fz.centralus-01.azurewebsites.net")
              .AllowAnyHeader() 
              .AllowAnyMethod(); 
    });
});

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieApiClient, MovieApiClient>();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowAngular");
app.UseAuthorization();

app.MapControllers();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
