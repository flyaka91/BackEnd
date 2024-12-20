using BackEnd.Models.Requests.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Library_Management_System.Core;
using Library_Management_System.DAL;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<RegisterUserRequestValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateUserRequestValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<AddBookRequestValidator>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LibraryManagementSystemContext>(options =>
options.UseNpgsql(Options.ConnectionString));
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
