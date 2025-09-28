using Microsoft.EntityFrameworkCore;
using SchoolProject.infrastructure.Data;
using SchoolProject.infrastructure.IRepositories;
using SchoolProject.infrastructure.Reposotories;
using SchoolProject.infrastructure;
using SchoolProject.Services;
using SchoolProject.Core;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Connection SQL
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});

#region DebndancyInjection
builder.Services.AddInfastructuredependency().AddServicedependency().AddCoredependency();
#endregion
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
