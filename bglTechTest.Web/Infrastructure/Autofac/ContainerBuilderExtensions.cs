using Autofac;
using AutoMapper;
using MediatR;

namespace bglTechTest.Web.Infrastructure.Autofac
{
    internal static class ContainerBuilderExtensions
    {
        public static void RegisterMediator(this ContainerBuilder builder)
        {
            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });
        }

        public static void RegisterAutoMapper(this ContainerBuilder builder)
        {
            var config = new MapperConfiguration(
                cfg => cfg.AddProfiles(typeof(MvcApplication).Assembly
                                      ,typeof(GitHubApiClient.GitHubApiClient).Assembly));

            var mapper = config.CreateMapper();

            builder.Register(ctx => mapper).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}