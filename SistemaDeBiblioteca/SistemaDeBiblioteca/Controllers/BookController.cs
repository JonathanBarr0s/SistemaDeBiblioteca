using Microsoft.AspNetCore.Mvc;
using SistemaDeBiblioteca.Model;
using SistemaDeBiblioteca.ViewModel;

namespace SistemaDeBiblioteca.Controllers
{
	[ApiController]
	[Route("api/book")]
	public class BookController : Controller
	{
		private readonly IBookRepository _bookRepository;

		public BookController(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
		}

		[HttpPost]
		public IActionResult Add(BookViewModel bookView)
		{
			var book = new Book(bookView.Title, bookView.Author, bookView.Year, bookView.NumberPages);

			_bookRepository.add(book);

			return Ok();
		}

		[HttpGet]
		public IActionResult Get()
		{
			var books = _bookRepository.Get();
			return Ok(books);
		}
	}
}
