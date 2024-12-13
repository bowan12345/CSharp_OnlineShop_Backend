using Autofac;
using System.Reflection;

namespace OnlineShop.Configuration
{
    public class AutofacModuleRegister:Autofac.Module
    {
        /// <summary>
        /// auto di register all modules
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            Assembly irepositories = Assembly.Load("OnlineShop.IRepository");
            Assembly repositories = Assembly.Load("OnlineShop.Repository");
            Assembly iservices = Assembly.Load("OnlineShop.IServices");
            Assembly services = Assembly.Load("OnlineShop.Services");
            builder.RegisterAssemblyTypes(irepositories, repositories, iservices, services)
               .AsImplementedInterfaces()
               .InstancePerLifetimeScope();
        }
    }
}
