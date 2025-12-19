using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;


#nullable disable

namespace SistemaDeBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSistemaDeBiblioteca_Books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(@"
				INSERT INTO ""SistemaDeBiblioteca_Books"" (""Title"", ""Author"", ""Year"", ""NumberPages"") VALUES
					('Dom Casmurro', 'Machado de Assis', 1899, 256 ),
                    ('O Senhor dos Anéis: A Sociedade do Anel', 'J.R.R. Tolkien', 1954, 576 ),
                    ('1984', 'George Orwell', 1949, 328 ),
                    ('O Pequeno Príncipe', 'Antoine de Saint-Exupéry', 1943, 96 ),
                    ('Harry Potter e a Pedra Filosofal', 'J.K. Rowling', 1997, 264 ),
                    ('A Revolução dos Bichos', 'George Orwell', 1945, 112 ),
                    ('O Código Da Vinci', 'Dan Brown', 2003, 489 ),
                    ('Orgulho e Preconceito', 'Jane Austen', 1813, 432 ),
                    ('O Hobbit', 'J.R.R. Tolkien', 1937, 310 ),
                    ('Crime e Castigo', 'Fiódor Dostoiévski', 1866, 671 );"
			);		
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
