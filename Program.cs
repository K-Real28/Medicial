using AutoMapper;
using Medicial;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql("name=ConnectionStrings:DefaultConnection"));
//builder.Services.AddSpaStaticFiles();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/dist";
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseSpa(spa =>
//{
//    spa.Options.SourcePath = "ClientApp";
//    if (app.Environment.IsDevelopment())
//    {
//        spa.UseAngularCliServer(npmScript: "start");
//        //spa.UseProxyToSpaDevelopmentServer("http://localhost:44417");
//    }
//});
app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

app.UseCors("AllowAllOriginal");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseDefaultFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();