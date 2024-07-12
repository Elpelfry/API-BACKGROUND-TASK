using BACKGROUND_TASK.Services.Admiciones;
using Shared.Models;
using Shared.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IApiService<Admisiones>, AdmisionesService>();
builder.Services.AddSingleton<ICache<Admisiones>, AdmisionesCache>();
builder.Services.AddHostedService<BackgroundTaskAdmisiones>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
