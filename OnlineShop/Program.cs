using Autofac.Core;
using Autofac;
using OnlineShop.IRepository;
using OnlineShop.Repository;
using Autofac.Extensions.DependencyInjection;
using OnlineShop.Admin;
using SqlSugar;
using System.ComponentModel;

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
