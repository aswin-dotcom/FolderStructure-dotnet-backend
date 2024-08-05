
using Microsoft.EntityFrameworkCore;
using PFS.Application.Models;
using PFS.Perseistance.DBcontext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<PFS.Application.Operations.Get>();
builder.Services.AddScoped<PFS.Application.Operations.GetByID>();
builder.Services.AddScoped<PFS.Application.Operations.DeleteById>();
builder.Services.AddScoped<PFS.Application.Operations.UpdateBYID>();
builder.Services.AddScoped<PFS.Application.Operations.PatchBYID>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultSQLConnection")));

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
