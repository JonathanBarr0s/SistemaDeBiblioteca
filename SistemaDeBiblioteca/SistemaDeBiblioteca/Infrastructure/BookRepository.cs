using Microsoft.EntityFrameworkCore;
using SistemaDeBiblioteca.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace SistemaDeBiblioteca.Infrastructure
{
	public class BookRepository : IBookRepository
	{
		private readonly AppDbContext _context;

		public BookRepository(AppDbContext context)
		{
			_context = context;
		}

		public void add(Book book)
		{
			_context.Books.Add(book);
			_context.SaveChanges();
		}

		public void DeleteById(int id)
		{
			var book = _context.Books.FirstOrDefault(b => b.Id == id);
			if (book != null)
			{
				_context.Books.Remove(book);
				_context.SaveChanges();
			}
		}

		public List<Book> Get()
		{
			return _context.Books.ToList();
		}

		public Book GetById(int id)
		{
			return _context.Books.FirstOrDefault(book => book.Id == id);
		}

		public void Update(Book book)
		{
			var existingBook = _context.Books.FirstOrDefault(b => b.Id == book.Id);

			if (existingBook != null)
			{
				existingBook.Title = book.Title;
				existingBook.Author = book.Author;
				existingBook.NumberPages = book.NumberPages;
				existingBook.Year = book.Year;

				_context.SaveChanges();
			}
		}
	}
}
