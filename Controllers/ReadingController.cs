using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OPM.Models;

namespace OPM.Controllers
{
    public class ReadingController : Controller
    {
        static private List<Books> Books = new List<Books>();
        public IActionResult Index()
        {
            ViewBag.booklist = Books;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Reading/Add")]
        public IActionResult NewReadingList(string bookTitle, string authName, int totalPages, int currentPages, bool compPages, DateTime compDate)
        {
            Books.Add(new Books(bookTitle, authName, totalPages, currentPages, compPages, compDate));

            return Redirect("/Reading");
        }


    }
}
