using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class Books
    {
        public int Id { get; set; }

        public string BookTitle { get; set; }
        public string AuthName { get; set; }

        public int TotalPage { get; set; }

        public int StartPage { get; set; }
        public DateTime StartDate { get; set; }   

        public Books(string bookTitle, string authName, int totalPages, int startPage, DateTime startDate)
        {
            BookTitle = bookTitle;
            AuthName = authName;
            TotalPage = totalPages;
            StartPage = startPage;
            StartDate = startDate;
        }

        public Books()
        {

        }

    }

    
    



}
