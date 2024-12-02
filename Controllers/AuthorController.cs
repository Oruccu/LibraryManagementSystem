using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace LibraryManagementSystem.Controllers;

public class AuthorController : Controller
{
    public IActionResult Index()
    {

        List<AuthorViewModel> dataAuthor = DataAuthor.Authors
        .Select(a => new AuthorViewModel()
        {
            Id = a.Id,
            FirstName = a.FirstName,
            LastName = a.LastName,
            DateOfBirth = a.DateOfBirth,
            BookCount = DataBook.Books?.FirstOrDefault(t => t.Id == a.Id)?.CopiesAvailable ?? 0
        }).ToList();

        return View(dataAuthor);
    }

    //-----------------------------------New Author Create----------------------------------
    public IActionResult AuthorCreate()
    {
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "FirstName");
        return View();
    }

    [HttpPost]
    public IActionResult AuthorCreate(NewAuthor newAuthor)
    {
        if (ModelState.IsValid)
        {
            Author author = new Author()
            {
                Id = DataAuthor.Authors?.Max(a => a.Id) + 1 ?? 1, // Yeni ID oluştur
                FirstName = newAuthor.Name,
                LastName = newAuthor.LastName,
                DateOfBirth = newAuthor.DateOfBirth
            };
            DataAuthor.Authors.Add(author);
            return RedirectToAction("Index");
        }
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "FirstName");
        return View(); // Model geçersizse aynı sayfaya dön
    }

    //---------------------------------------Delete----------------------------------

    public IActionResult DeleteCheck(int id)
    {
        Author? author = DataAuthor.Authors.FirstOrDefault(t => t.Id == id);
        if (author == null)
        {
            return NotFound();
        }

        // Yazara ait kitap var mı kontrol et
        var book = DataBook.Books?.FirstOrDefault(t => t.AuthorId == author.Id);

        // Eğer kitap null değilse ve CopiesAvailable > 0 ise işlem yapılamaz
        if (book != null && book.CopiesAvailable > 0)
        {
            // Kitap mevcut ve kopyaları var, silme işlemine izin verme
            TempData["ErrorMessage"] = $"{author.FirstName} {author.LastName} ait kitap kaydı bulunmaktadır. Silme işlemine izin verilmez.";
            return RedirectToAction("Index");
        }

        // Eğer sorun yoksa silme onayı için view döndür
        return View(author);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        Author? author = DataAuthor.Authors.FirstOrDefault(t => t.Id == id);
        if (author == null)
        {
            return NotFound();
        }
        DataAuthor.Authors.Remove(author);
        return RedirectToAction("Index");
    }
    //-----------------------------------------Update----------------------------------

    public IActionResult Update(int id)
    {
        Author? author = DataAuthor.Authors.FirstOrDefault(a => a.Id == id);
        if (author == null)
        {
            return NotFound();
        }

        AuthorUpdateViewModel vm = new AuthorUpdateViewModel()
        {
            Id = author.Id,
            Name = author.FirstName,
            LastName = author.LastName,
            DateOfBirth = author.DateOfBirth
        };
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "Name");
        return View(vm);
    }

    [HttpPost]
    public IActionResult Update(AuthorUpdateViewModel vm)
    {
        Author? author = DataAuthor.Authors.FirstOrDefault(a => a.Id == vm.Id);
        if (author == null)
        {
            return NotFound();
        }

        if(ModelState.IsValid){
            author.FirstName = vm.Name;
            author.LastName = vm.LastName;
            author.DateOfBirth = vm.DateOfBirth;
            return RedirectToAction("Index");
        }
        ViewBag.Authors = new SelectList(DataAuthor.Authors, "Id", "Name");
        return View(vm);
    }

}
