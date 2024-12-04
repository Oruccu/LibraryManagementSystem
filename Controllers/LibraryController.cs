using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace LibraryManagementSystem.Controllers;

public class LibraryController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new LibraryViewModel
        {
            Books = DataBook.Books,
            Authors = DataAuthor.Authors
        };

        return View(viewModel);
    }
    //------------------Details------------------------
    public IActionResult Details(int id)
    {
        Book? book = DataBook.Books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }
        var author = DataAuthor.Authors?.FirstOrDefault(a =>a.Id == book.AuthorId);
        BookDetails vm = new BookDetails()
        {
            Id = book.Id,
            Title = book.Title,
            AuthorName = $"{author.FirstName} {author.LastName}",
            Genre = book.Genre,
            PublishDate = book.PublishDate,
            ISBN = book.ISBN,
            CopiesAvailable = book.CopiesAvailable
        };
        return View(vm);
    }
    //---------New Author Create-----------
    public IActionResult AuthorCreate()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AuthorCreate(NewAuthor newAuthor)
    {
        if (ModelState.IsValid)
        {
            Author author = new Author()
            {
                Id = DataAuthor.Authors.Max(a => a.Id) + 1,
                FirstName = newAuthor.Name,
                LastName = newAuthor.LastName,
                DateOfBirth = newAuthor.DateOfBirth
            };
            DataAuthor.Authors.Add(author);
            return RedirectToAction("Index");
        }

        return View(newAuthor);
    }

    //--------------------------New Book Create---------------
    public IActionResult BookCreate()
    {
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "FirstName");
        return View();
    }
    [HttpPost]
    public IActionResult BookCreate(NewBook newBook)
    {
        if (ModelState.IsValid)
        {
            Book book = new Book()
            {
                Id = DataBook.Books.Max(a => a.Id) + 1,
                Title = newBook.Title,
                AuthorId = newBook.AuthorId,
                Genre = newBook.Genre,
                PublishDate = newBook.PublishDate,
                ISBN = newBook.ISBN,
                CopiesAvailable = newBook.CopiesAvailable
            };
            DataBook.Books.Add(book);
            return RedirectToAction("Index");
        }
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "FirstName");
        return View(newBook);
    }

    //-------------------------Delete-------------------------
    public IActionResult DeleteCheck(int id)
    {
        if (DataBook.Books == null)
        {
            return NotFound();
        }

        Book? book = DataBook.Books.FirstOrDefault(a => a.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        if (DataBook.Books == null)
        {
            return NotFound();
        }

        Book? book = DataBook.Books.FirstOrDefault(a => a.Id == id);

        if (book == null)
        {
            return NotFound();
        }

        DataBook.Books.Remove(book);
        return RedirectToAction("Index");
    }

    //-----------------------------Update-----------------------

    public IActionResult Update(int id)
    {
        Book? book = DataBook.Books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        BookUpdateViewModal vm = new BookUpdateViewModal()
        {
            Id = book.Id,
            Title = book.Title,
            AuthorId = book.AuthorId,
            Genre = book.Genre,
            PublishDate = book.PublishDate,
            ISBN = book.ISBN,
            CopiesAvailable = book.CopiesAvailable,
        };
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "FirstName");
        return View(vm);
    }

    [HttpPost]
    public IActionResult Update(BookUpdateViewModal vm)
    {
        Book? book = DataBook.Books.FirstOrDefault(b => b.Id == vm.Id);
        if (book == null)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            book.Title = vm.Title;
            book.AuthorId = vm.AuthorId;
            book.Genre = vm.Genre;
            book.PublishDate = vm.PublishDate;
            book.ISBN = vm.ISBN;
            book.CopiesAvailable = vm.CopiesAvailable;
            return RedirectToAction("Index");
        }
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "FirstName");
        return View(vm);
    }

}