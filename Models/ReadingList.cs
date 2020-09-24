using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class ReadingList
    {
        public int Id { get; set; }

        public Books BookData { get; set; } //iedally the title, author, totalpage

        public int BookDataId { get; set; }  //foreign key in our table 
        //But is this the best option
        //Could we collect  -- do we EVEN need a foreign key?
            //nothing (as of right now) is really spearate from the initial book object.
            //Want to UPDATE only the page numbers
            //Want to have SEPARATE powers via parent child...perhaps seperate MCVs for those?
            

        public int  CurrentPage { get; set; }  //UPDATEABLE
    
        public ReadingList (int currentPage, bool finished)
        {
            CurrentPage = currentPage;
        }

        public ReadingList ()
        {

        }
    
    
    }

    //Review Coding events for the edit funtion.  I forget where we did that...
    //Review Tech jobs for the interactive tables (clicking on title, not a check box with number)

}
