using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class AddShelfViewModel
    {
        public int BookId { get; set; }

        public List<SelectListItem> Books { get; set; }


        public AddShelfViewModel(List<Books> books)
        {
            Books = new List<SelectListItem>();

            foreach (Books book in books)
            {
                Books.Add(new SelectListItem
                {
                    Value = book.Id.ToString(),
                    Text = book.BookTitle
                });
                

            }
        }
    }
}
