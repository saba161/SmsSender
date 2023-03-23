using SmsSender;
using SmsSender.Providers;
using SmsSender.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var enviroment = builder.Environment;

builder.Services.AddTransient<IService, Service>();

if (!enviroment.IsDevelopment())
{
    builder.Services.AddTransient<ISmsSender, Magti>();
}
else //For example Production enviroment
{
    builder.Services.AddTransient<ISmsSender, Beeline>();
}

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();