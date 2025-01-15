using Microsoft.EntityFrameworkCore;
using SistemaDeBiblioteca.Model;
using System.Data.Common;

namespace SistemaDeBiblioteca.Infrastructure
{
	public class ConnectionContext : DbContext
	{
		public DbSet<Book> Books { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		  => optionsBuilder.UseNpgsql(
			  "Server=localhost;" +
			  "Port=5432;Database=Biblioteca;" +
			  "User Id=postgres;" +
			  "Password=1234;");
	}
}
