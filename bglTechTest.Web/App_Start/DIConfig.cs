using Autofac;
using Autofac.Integration.Mvc;
using bglTechTest.GitHubApiClient.Infrastructure.Autofac;
using bglTechTest.Web.Infrastructure.Autofac;
using System.Web.Mvc;

namespace bglTechTest.Web
{
    public static class DIConfig
    {
        public static void RegisterDependencyInjection()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule(new WebModule());
            builder.RegisterModule(new GitHubApiClientModule());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}