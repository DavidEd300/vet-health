using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using vet_health.Infrastructure.Identity;
using vet_health.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<VetHealthDbContext>(opt =>
    opt.UseSqlServer(conn));

builder.Services
    .AddIdentity<ApplicationUser, IdentityRole<Guid>>(opt =>
    {
        opt.Password.RequiredLength = 6;
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequireUppercase = false;
        opt.Password.RequireLowercase = false;
        opt.Password.RequireDigit = false;
        opt.User.RequireUniqueEmail = true;
    })
    .AddEntityFrameworkStores<VetHealthDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
