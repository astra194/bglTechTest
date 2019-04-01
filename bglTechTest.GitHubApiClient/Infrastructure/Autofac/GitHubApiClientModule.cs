using Autofac;

namespace bglTechTest.GitHubApiClient.Infrastructure.Autofac
{
    public class GitHubApiClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(GitHubApiClientModule).Assembly).AsImplementedInterfaces();

            builder.RegisterHttpClient();
        }
    }
}
