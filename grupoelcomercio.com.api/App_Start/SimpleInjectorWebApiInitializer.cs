[assembly: WebActivator.PostApplicationStartMethod(typeof(grupoelcomercio.com.api.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace grupoelcomercio.com.api.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using Repository;
    using OrdenDePago.Contracts;
    using CommandHandler;
    using Commands;

    public static class SimpleInjectorWebApiInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            //porque nuestro repositorio será en memoria
            container.Register<IDbContext, InMemoryDatabase>(Lifestyle.Singleton);
            container.Register<IOrdenRepository, OrdenRepository>(Lifestyle.Singleton);
            container.Register<ICommandHandler<PagarOrden>, OrdenHandler>();
            container.Register<ICommandHandler<RegistrarBanco>, OrdenHandler>();
            container.Register<ICommandHandler<RegistrarSucursal>, OrdenHandler>();

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}