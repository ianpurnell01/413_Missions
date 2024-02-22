using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Mission06_Purnell.Models
{
    public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options)
        {
        }

        public DbSet<NewMovie> Movies { get; set; }
    }
}
