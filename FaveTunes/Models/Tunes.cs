using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FaveTunes.Models
{
    public class Tunes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime DateAdded { get; set; }
        public string Genre { get; set; }
    }

    // TunesDbContext = Entity Framework songs(tunes) database context
    public class TunesDbContext : DbContext
    {
        // collection of entities from Tunes context
        public DbSet<Tunes> Tunes { get; set; }
    }
}