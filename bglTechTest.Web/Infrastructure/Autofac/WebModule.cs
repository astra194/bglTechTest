using Autofac;

namespace bglTechTest.Web.Infrastructure.Autofac
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(WebModule).Assembly).AsImplementedInterfaces();

            builder.RegisterMediator();
            builder.RegisterAutoMapper();
        }
    }
}