using Autofac;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace bglTechTest.GitHubApiClient.Infrastructure.Autofac
{
    internal static class ContainerBuilderExtensions
    {
        public static void RegisterHttpClient(this ContainerBuilder builder)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("bglTechTest");

            builder.RegisterInstance(client).SingleInstance();
        }
    }
}
