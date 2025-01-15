using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeBiblioteca.Model
{

	[Table("Books")]

	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public int Year { get; set; }
		public int NumberPages { get; set; }

		public Book(string title, string author, int year, int numberPages)
		{
			Title = title ?? throw new ArgumentNullException(nameof(title));
			Author = author ?? throw new ArgumentNullException(nameof(author));
			Year = year;
			NumberPages = numberPages;
		}
	}
}
