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

        [Required(ErrorMessage ="** Please select a title**")]
       
        public List<SelectListItem> BookData { get; set; }

        public AddReadingListViewModel(List<Books> bookdata)
        {
            BookData = new List<SelectListItem>();

            foreach (var bookdatum in bookdata)
            {
                BookData.Add(new SelectListItem
                {
                    Value = bookdatum.Id.ToString(),
                    Text = bookdatum.BookTitle
                });
            }
        }

        public AddReadingListViewModel()
        {

        }
    }
}
