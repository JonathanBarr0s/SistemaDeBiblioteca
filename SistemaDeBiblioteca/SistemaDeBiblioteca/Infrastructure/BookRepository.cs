using SistemaDeBiblioteca.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace SistemaDeBiblioteca.Infrastructure
{
	public class BookRepository : IBookRepository
	{
		private readonly ConnectionContext _context = new ConnectionContext();

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
	}
}
