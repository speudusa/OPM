using Microsoft.AspNetCore.Mvc.Rendering;
using OPM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.ViewModels
{
    public class AddReadingListViewModel
    {
        [Required(ErrorMessage = "** Please enter your current page number **")]
        public int CurrentPage { get; set; }

        [Required(ErrorMessage =" ** Please select today's date **")]
        public DateTime ReadToday { get; set; }


        public int BookId { get; set; }

        [Required(ErrorMessage = "** Please select a title**")]
        public List<SelectListItem> Book { get; set; }

        public AddReadingListViewModel(List<Books> books)
        {
            Book = new List<SelectListItem>();

            foreach (var book in books)
            {
                Book.Add(
                    new SelectListItem
                        {
                            Value = book.Id.ToString(),
                            Text = book.BookTitle
                        }
                    );
            }
        }

        public AddReadingListViewModel()
        {

        }
    }
}
