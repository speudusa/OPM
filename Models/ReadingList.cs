using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class ReadingList  
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public int  CurrentPage { get; set; }  //UPDATEABLE here

        public DateTime ReadToday { get; set; }
    
        public Books Book { get; set; }

        public int BookId { get; set; }




        public ReadingList (Books books, int currentPage, DateTime readToday)
        {
            Book = books;  
            CurrentPage = currentPage;
            ReadToday = readToday;

        }

        public ReadingList()
        {

        }
    
    
    }

}
