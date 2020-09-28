﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OPM.Data;
using OPM.Models;
using OPM.ViewModels;

namespace OPM.Controllers
{
    public class BooksController : Controller
    {
        private BookDbContext context; 


        public BooksController(BookDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Books> books = context.Books.ToList();

            return View(books);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            AddBookViewModel addBookViewModel = new AddBookViewModel();

            return View(addBookViewModel);
        }

        [HttpPost] 
        public IActionResult AddBook(AddBookViewModel addBookViewModel)
        {
            if (ModelState.IsValid)
            {
                Books newBook = new Books
                {
                    BookTitle = addBookViewModel.BookTitle,
                    AuthName = addBookViewModel.AuthName,
                    TotalPages = addBookViewModel.TotalPages
                };

                context.Books.Add(newBook);
                context.SaveChanges();

                return Redirect("/Books");  //This is the ONLY instance of this view...  (Books/Index)
                    //Utilize in future???
            }

            return View(addBookViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.books = context.Books.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] bookIds)
        {
            foreach(int bookId in bookIds)
            {
                Books theBook = context.Books.Find(bookId);
                context.Books.Remove(theBook);
            }

            context.SaveChanges();

            return Redirect("/Books");
        }

    }
}

//
