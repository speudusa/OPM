using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.ViewModels
{
    public class AddBookViewModel
    {
        [Required(ErrorMessage = "** Please enter the title of your book. **")]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "** Please enter the author's first and last name. **")]
        public string AuthName { get; set; }

        [Required(ErrorMessage = "** Please enter the total number of pages in your book. **")]
        public int TotalPages { get; set; }
       
        [Required(ErrorMessage ="** Please enter the page number you are starting at. **")]
        public int StartPage { get; set; }



      

    }
}
