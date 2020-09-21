using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class ReadingList
    {
        public int Id { get; set; }

        public string BookTitle //get from book index??

        public string AuthName //from book index

        public int  TotalPages  //from book index

        public int  CurrentPage { get; set; }  //UPDATEABLE

        public bool Finished { get; set; }
    
        public ReadingList (string bookTitle, string authName, int totalPages, int currentPages)
        {
            BookTitle = bookTitle;

        }

        public ReadingList ()
        {

        }
    
    
    }


}
