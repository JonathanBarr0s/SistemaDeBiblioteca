namespace SistemaDeBiblioteca.Configurations.OpenApi
{
	public static class SwaggerAppConfig
	{
		public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sistema de Biblioteca v1");
				c.RoutePrefix = string.Empty;
			});

			return app;
		}
	}
}