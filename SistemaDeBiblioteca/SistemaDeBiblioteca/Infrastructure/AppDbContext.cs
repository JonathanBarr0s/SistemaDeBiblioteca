using Microsoft.EntityFrameworkCore;
using SistemaDeBiblioteca.Model;
using System.Data.Common;

namespace SistemaDeBiblioteca.Infrastructure
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
		{
		}

		public DbSet<Book> Books { get; set; }	
	}
}
