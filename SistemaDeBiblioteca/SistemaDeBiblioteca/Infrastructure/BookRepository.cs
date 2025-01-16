using SistemaDeBiblioteca.Model;

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
