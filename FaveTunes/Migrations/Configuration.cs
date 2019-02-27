namespace FaveTunes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    // added for reference to Model 
    using FaveTunes.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FaveTunes.Models.TunesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FaveTunes.Models.TunesDbContext";
        }

        protected override void Seed(FaveTunes.Models.TunesDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Tunes.AddOrUpdate(i => i.Title,
                new Tunes
                {
                    Title = "September",
                    Artist = "Earth, Wind & Fire", 
                    Album = "September",
                    DateAdded = DateTime.Parse("2018-4-17"),
                    Genre = "Disco, Classic Soul"
                },  

                new Tunes
                {
                    Title = "Everybody Knows",
                    Artist = "Nulbarich",
                    Album = "Guess Who?",
                    DateAdded = DateTime.Parse("2016-9-12"),
                    Genre = "Rock"
                },

                new Tunes
                {
                    Title = "24k Magic",
                    Artist = "Bruno Mars",
                    Album = "24k Magic",
                    DateAdded = DateTime.Parse("2016-11-17"),
                    Genre = "Funk, Post-disco, Contemporary R&B"
                },

                new Tunes
                {
                    Title = "This Love",
                    Artist = "Maroon 5",
                    Album = "Songs About Jane",
                    DateAdded = DateTime.Parse("2004-01-27"),
                    Genre = "Pop"
                }    
            );
        }
    }
}
