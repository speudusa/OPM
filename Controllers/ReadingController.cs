using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OPM.Models;
using OPM.ViewModels;
using OPM.Data;

namespace OPM.Controllers
{
    public class ReadingController : Controller
    {
        private BookDbContext context;

        public ReadingController(BookDbContext dbContext)
        {
            context = dbContext;
        }

        //GET
        public IActionResult Index()
        {
            List<Books> readingLists = context.Books.ToList();

            return View(readingLists);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            List<Books> books = context.Books.ToList();
            AddReadingListViewModel addReadingListViewModel = new AddReadingListViewModel(books);

            return View(addReadingListViewModel);
        }

        [HttpPost]
        //creating new instance for the list which will be presented on the ARLVM
        [Route("/Reading/Add")]
        public IActionResult NewReadingList(AddReadingListViewModel addReadingListViewModel)  
        {
           if (ModelState.IsValid)
            {
                Books theBook = context.Books.Find(addReadingListViewModel.BookId);
                ReadingList newList = new ReadingList  
                {
                    Book = theBook,
                    ReadToday = addReadingListViewModel.ReadToday,
                    CurrentPage = addReadingListViewModel.CurrentPage,
                };
                //TODO:  figure this out
                context.Books.Add(newList);
                context.SaveChanges();
            }
            return Redirect("/Reading"); 
        }
    }
}

//TODO could I use an About option like we did in Tech Jobs?

//TODO what if I have a separate view for completed books with buttons to go between lists?

//TODO want to be able to EDIT pages on this Controller