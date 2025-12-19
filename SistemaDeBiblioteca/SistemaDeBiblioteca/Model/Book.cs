using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SistemaDeBiblioteca.Model
{

	[Table("SistemaDeBiblioteca_Books")]

	public class Book
	{
		[JsonPropertyName("Código")]
		public int Id { get; set; }

		[JsonPropertyName("Título")]
		public string Title { get; set; }

		[JsonPropertyName("Autor")]
		public string Author { get; set; }

		[JsonPropertyName("Ano")]
		public int Year { get; set; }

		[JsonPropertyName("Numero_de_Paginas")]
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
