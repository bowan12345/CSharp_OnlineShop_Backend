using Autofac;
using Autofac.Extensions.DependencyInjection;
using SqlSugar;
using OnlineShop.Configuration;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//replace inner IOC container with Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(container =>
{
    #region Register Modules using autofac
    container.RegisterModule(new AutofacModuleRegister());
    #endregion

    #region register sql connection using sqlsugarclient
    /*  container.Register(c => new SqlSugarClient(new ConnectionConfig()
      {
          //ConnectionString = "Data Source=localhost;Initial Catalog=OnlineShop;Integrated Security=True",
          //DbType = DbType.SqlServer,
          ConnectionString = builder.Configuration.GetConnectionString("SqlConnection"),
          DbType = DbType.MySql,
          IsAutoCloseConnection = true,
      })).As<ISqlSugarClient>();*/
    #endregion

    #region register sql connection using sqlSugarScope
    container.Register(c => new SqlSugarScope(
        new ConnectionConfig
        {
            ConnectionString = builder.Configuration.GetConnectionString("SqlConnection"),
            DbType = DbType.MySql,
            IsAutoCloseConnection = true,
        }
    ))
    .As<SqlSugarScope>()
    .SingleInstance(); // single instance for all request
    #endregion

});
// add AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));

// loading  CORS from appsetting.json
var corsConfig = builder.Configuration.GetSection("Cors");

// add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("DynamicCorsPolicy", policy =>
    {
        var allowedOrigins = corsConfig.GetSection("AllowedOrigins").Get<string[]>();
        if (allowedOrigins != null && allowedOrigins.Length > 0)
        {
            policy.WithOrigins(allowedOrigins); 
        }
        if (corsConfig.GetValue<bool>("AllowAnyHeader"))
        {
            policy.AllowAnyHeader();
        }

        if (corsConfig.GetValue<bool>("AllowAnyMethod"))
        {
            policy.AllowAnyMethod();
        }

        if (corsConfig.GetValue<bool>("AllowCredentials"))
        {
            policy.AllowCredentials();
        }
    });
});

// add jwt
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddScoped<JWTHelper>();

// add jwt Bearer authentication into  Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        Description = "Please enter a valid JWT token"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

var app = builder.Build();

// Use CORS middleware
app.UseCors("DynamicCorsPolicy");

// Configure the HTTP request pipeline.
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
