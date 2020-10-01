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
            List<Books> readingLists = context.Books.ToList();  //TODO 1.  Fix this
            //TODO 2.  Look into InputDate ?

            return View(readingLists);
            //I want to call the Book Db to fill this Shelf
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
                //look at the relationship here
               Books theBook = context.Books.Find(addReadingListViewModel.BookId);
                ReadingList newList = new ReadingList  
                {
                   books = theBook,
                    ReadToday = addReadingListViewModel.ReadToday,
                    CurrentPage = addReadingListViewModel.CurrentPage,
                };
                //TODO:  Create DBContext for Reading List
                context.ReadingLists.Add(newList);
                context.SaveChanges();
            }
            return Redirect("/Reading"); 
        }
        //HttpGet
        public IActionResult UpdateList(/*reading list*/)
        {
            //retrieve selected book based on DD by title

            return View();
        }
        /*
        //TODO:  Chapter 14.5 build edit function

        //  CHILD USER
        //HttpPost
        public IActionResult UpdatePageAndDate (/*reading list)
        {
            //post updated table row
            //save changes

            return View();
        }

        //PARENT USER (UpdateEntireBookObject AND DeleteBookObject
        //HttpPost
        public IActionResult UpdateEntireBookObject (/* reading list )
        {
            //update all aspects of selected book
        }

        //HttpPost
        public IActionResult DeleteBookObject (/*reading list)
        {
            //option for editing books in PARENT VIEW
            //legit delete books (and choose or as indicated by date)

            return View();
        }
    */

    }
}

//TODO could I use an About option like we did in Tech Jobs?  
        //(To see infor about each book when you click on title)


//TODO what if I have a separate view for completed books with buttons to go between lists?
        //eh...  this seems like a PITA

//TODO want to be able to EDIT pages on this Controller
        //Yes, still need to review this