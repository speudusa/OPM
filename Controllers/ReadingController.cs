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
            //List<ReadingList> readingLists = context.ReadingList.ToList();

            return View();
        }

        [HttpGet]
        //Retrieives current (persisent) data from my ARLVM
        public IActionResult Add()
        {

            AddReadingListViewModel addReadingListViewModel = new AddReadingListViewModel();

            return View(addReadingListViewModel);
        }

        [HttpPost]
        //creating new instance for the list which will be presented on the ARLVM
        [Route("/Reading/Add")]
        public IActionResult NewReadingList(AddReadingListViewModel addReadingListViewModel)  
        {
           if (ModelState.IsValid)
            {
                ReadingList newList = new ReadingList  //ONLY updating this page
                {
                    CurrentPage = addReadingListViewModel.CurrentPage,
                };
                //context.ReadingList.Add(newList);
                context.SaveChanges();
            }
            return Redirect("/Reading");  //Check this
        }

        //link to find id for the book to edit and not RE-ADDING entire book
        //see coding events and Ben's walkthrough 
    }
}

//TODO could I use an About option like we did in Tech Jobs?

//TODO what if I have a separate view for completed books with buttons to go between lists?

//TODO want to be able to EDIT pages on this Controller