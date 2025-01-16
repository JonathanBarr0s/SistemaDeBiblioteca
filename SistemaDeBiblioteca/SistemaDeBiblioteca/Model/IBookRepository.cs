namespace SistemaDeBiblioteca.Model
{
	public interface IBookRepository
	{
		void add(Book book);

		List<Book> Get();

		Book GetById(int id);
	}
}
