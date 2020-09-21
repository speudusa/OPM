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
        public int CurrentPages { get; set; }
        public bool CompPages { get; set; }
        public DateTime CompDate { get; set; }



        public Books()
        {

        }

        public Books(string bookTitle, string authName, int totalPages, int currentPages, bool compPages, DateTime compDate)
        {
            BookTitle = bookTitle;
            AuthName = authName;
            TotalPages = totalPages;
            CurrentPages = currentPages;
            CompPages = compPages;
            CompDate = compDate;
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        //public override bool Equals(object obj)
        //{
        //    return obj is Books @book &&
        //        Id == @book.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}
    }

    
    



}
