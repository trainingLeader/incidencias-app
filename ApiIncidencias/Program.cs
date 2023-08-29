using System.Reflection;
using System.Text;
using ApiIncidencias.Extensions;
using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddJwt(builder.Configuration);
builder.Services.AddControllers(options =>
{

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureRatelimiting();
builder.Services.ConfigureApiVersioning();

var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context"));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>{
    opt.TokenValidationParameters = new TokenValidationParameters{
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = key,
        ValidateAudience = false,
        ValidateIssuer = false
    };
});
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureCors();
builder.Services.AddAplicacionServices();
builder.Services.AddDbContext<ApiIncidenciasContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("ConexMysql");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
//-----------------JSON WEB TOKEN------------------------
// builder.Configuration.AddJsonFile("appsettings.json");
// var secretKey = builder.Configuration.GetSection("JWT").GetSection("Key").ToString();
// var keyBytes = Encoding.UTF8.GetBytes(secretKey);

// builder.Services.AddAuthentication(config => {
    
//     config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//     config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
// }).AddJwtBearer(config => {
//     config.RequireHttpsMetadata = false;
//     config.SaveToken = false;
//     config.TokenValidationParameters = new TokenValidationParameters
//     {
//         ValidateIssuerSigningKey = true,
//         IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
//         ValidateIssuer = false,
//         ValidateAudience = false
//     };
// });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();
app.UseIpRateLimiting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
