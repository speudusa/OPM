using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class Shelf
    {
        public int Id { get; set; }

        public Books Book { get; set; }

        public int BookId {get; set;}

        public string BookTitle { get; set; }

        public Shelf()
        { }

        public Shelf(int id)
        {
            Id = id,
        }
            //TODO:  START HERE!!
            //build constructor
            //Want to get the Book info to post here.  hmm....
    }




}
