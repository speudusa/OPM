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
    
       public List<Books> books { get; set; }

        public ReadingList (int currentPage, DateTime readToday)
        {
            CurrentPage = currentPage;
            ReadToday = readToday;
        }

        public ReadingList()
        {

        }
    
    
    }

}
