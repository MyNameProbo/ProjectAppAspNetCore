using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using VueAppProjectManagement.Project.Application;
using VueAppProjectManagement.Project.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProjectDbContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("PostgreConString"),
    b=>b.MigrationsAssembly("VueAppProjectManagement.Server")));
builder.Services.AddControllers();
var projectAppSpecificOrigin = "_projectAppSpecificOrigin";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: projectAppSpecificOrigin, policy => {
        policy.WithOrigins("https://localhost:5173/");
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});
builder.Services.AddScoped<IProjectTableService, ProjectTableService>();
builder.Services.AddScoped<IProjectTableRepository, ProjectTableRepository>();
builder.Services.AddScoped<IWorkerTableService, WorkerTableService>();
builder.Services.AddScoped<IWorkerTableRepository, WorkerTableRepository>();
builder.Services.AddScoped<IMaterialTableService, MaterialTableService>();
builder.Services.AddScoped<IMaterialTableRepository, MaterialTableRepository>();
builder.Services.AddScoped<IWorkingTableService, WorkingTableService>();
builder.Services.AddScoped<IWorkingTableRepository, WorkingTableRepository>();
builder.Services.AddScoped<IWorkingLineService, WorkingLineService>();
builder.Services.AddScoped<IWorkingLineRepository, WorkingLineRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");
app.UseCors(projectAppSpecificOrigin);
app.Run();
