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

        public int TotalPages { get; set; }

        public int StartPage { get; set; }
        public DateTime CompDate { get; set; } //still need to get this working


        public Books()
        {

        }

        public Books(string bookTitle, string authName, int totalPages, int startPage, DateTime compDate)
        {
            BookTitle = bookTitle;
            AuthName = authName;
            TotalPages = totalPages;
            StartPage = startPage;
            CompDate = compDate;
        }

    }

    
    



}
