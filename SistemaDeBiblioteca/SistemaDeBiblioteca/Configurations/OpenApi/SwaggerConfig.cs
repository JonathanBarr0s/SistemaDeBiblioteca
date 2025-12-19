using Microsoft.OpenApi.Models;

namespace SistemaDeBiblioteca.Configurations.OpenApi
{
	public static class SwaggerConfig
	{
		public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "Sistema de Biblioteca",
					Version = "v1",
					Description = string.Join("\n", new[]
					{
						"**Bem-vindo!**",
						"",
						"Esta API foi desenvolvida em **ASP.NET Core** e foi projetada para gerenciar **livros**. Ela disponibiliza endpoints para criação, consulta e atualização desses dados. Para mais detalhes sobre arquitetura, execução e código-fonte, acesse o repositório no GitHub clicando [aqui](https://github.com/JonathanBarr0s/SistemaDeBiblioteca).",
						"",
						"**Me acompanhe nas redes:**",
							"- **Docker Hub:** [hub.docker.com/u/jonathanbarr0s](https://hub.docker.com/u/jonathanbarr0s)",
							"- **GitHub:** [github.com/jonathanbarr0s](https://github.com/jonathanbarr0s)",
							"- **LinkedIn:** [linkedin.com/in/jonathansbarros](https://linkedin.com/in/jonathansbarros)"
					})
				});
			});

			return services;
		}
	}
}
