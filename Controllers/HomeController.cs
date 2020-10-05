

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OPM.Models;
using OPM.ViewModels;
using OPM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace OPM.Controllers
{
    public class HomeController : Controller
    {

        private BookDbContext context; 
        public int Id { get; private set; }


        public HomeController(BookDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Books> books = context.Books.Include(b => b.BookTitle).ToList();

            return View(books);
        }



        [HttpGet("/Add")]
        public IActionResult AddBook()
        {
            AddShelfViewModel addShelfViewModel = new AddShelfViewModel(context.Books.ToList());
            return View(addShelfViewModel);
        }

        [HttpPost("/Add")]
        public IActionResult Add(AddShelfViewModel addShelfViewModel)
        {
            
            if (ModelState.IsValid)
            {
                //Create New Shelf Object: includes Title, Author, current page number, total page number
                Shelf newShelf = new Shelf()
                {
                    BookTitle = addShelfViewModel.Book.BookTitle,
                    AuthName = addShelfViewModel.AuthName,
                    StartPage = addShelfViewModel.StartPage,
                    TotalPage = addShelfViewModel.TotalPage

                };

                //IF current page number !== total

                //ELSE 
                //title, author, total page number 

                context.Books.Add(newShelf);
                context.SaveChanges();

                return Redirect("/Home");
            }

            return View("Add", addBookViewModel);

            }
    }

        //Details function
            //Where book data can be updated:  page number and date time
            //Where book items can be deleted

}
