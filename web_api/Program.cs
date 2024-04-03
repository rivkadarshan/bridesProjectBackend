using Bll.classes;
using Bll.interfaces;
using Dal.classes;
using Dal.interfaces;
using Dal.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProjectBridesContext>(opt => opt.UseSqlServer("Server=DESKTOP-N3PRKSF;Database=PROJECT_BRIDES;Trusted_Connection=true;TrustServerCertificate=True;"));

builder.Services.AddScoped<IBrideDal, BrideFunc>();
builder.Services.AddScoped<IBrideBll, BrideBll>();
builder.Services.AddScoped<IBridejewelryDal, BridejewelryFunc>();
builder.Services.AddScoped<IBridejewelryBll, BridejewelryBll>();
builder.Services.AddScoped<ICorrectionBll, CorrectionBll>();
builder.Services.AddScoped<ICorrectionDal, CorrectionFunc>();
builder.Services.AddScoped<ICustomerBll, CustomerBll>();
builder.Services.AddScoped<ICustomerDal, CustomerFunc>();
builder.Services.AddScoped<IEmployeeBll, EmployeeBll>();
builder.Services.AddScoped<IEmployeeDal, EmployeeFunc>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("AllowSpecificOrigin");

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
