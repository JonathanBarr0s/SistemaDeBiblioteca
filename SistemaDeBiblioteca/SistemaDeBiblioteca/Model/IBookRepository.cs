namespace SistemaDeBiblioteca.Model
{
	public interface IBookRepository
	{
		void add(Book book);

		List<Book> Get();

		Book GetById(int id);

		void DeleteById(int id);

		void Update(Book book);
	}
}
