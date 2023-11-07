﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CourseCatalog.Data;
using CourseCatalog.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CourseCatalogContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CourseCatalogContext") ?? throw new InvalidOperationException("Connection string 'CourseCatalogContext' not found.")));

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
using (var context = new DbContext())
{
    context.Database.EnsureDeleted(); 
    context.Database.EnsureCreated(); 

    SeedData.Seed(context); 
}