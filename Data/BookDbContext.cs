using Microsoft.EntityFrameworkCore;
using OPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OPM.Data
{
    public class BookDbContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<ReadingList> ReadingLists { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options) 
            : base(options)
        {

        }
    }
}
