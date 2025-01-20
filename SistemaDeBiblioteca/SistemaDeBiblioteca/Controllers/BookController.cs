using Microsoft.AspNetCore.Mvc;
using SistemaDeBiblioteca.Model;
using SistemaDeBiblioteca.ViewModel;

namespace SistemaDeBiblioteca.Controllers
{
	[ApiController]
	[Route("book")]
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

		[HttpGet("{id:int}")]
		public IActionResult GetById(int id)
		{
			var book = _bookRepository.GetById(id);

			if (book == null)
			{
				return NotFound(new { message = "Livro não encontrado." });
			}

			return Ok(book);
		}

		[HttpDelete("{id:int}")]
		public IActionResult Delete(int id)
		{
			var book = _bookRepository.GetById(id);
			if (book == null)
			{
				return NotFound(new { message = "Livro não encontrado." });
			}

			_bookRepository.DeleteById(id);
			return NoContent();
		}
	}
}
