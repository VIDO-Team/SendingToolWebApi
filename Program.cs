using SendingTool.Data;
using SendingTool.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.Net.Http.Headers;
using System;


var builder = WebApplication.CreateBuilder(args);
string sConnection = builder.Configuration.GetConnectionString("SinhvienTTConnection");
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<SinhvienTTDbContext>(opt => opt.UseSqlServer(sConnection));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // app.UseSwagger();
//     app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
