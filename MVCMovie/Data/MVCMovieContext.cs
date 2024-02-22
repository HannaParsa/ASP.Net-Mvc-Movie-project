using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;

namespace MVCMovie.Data
{
    public class MVCMovieContext : DbContext
    {
        public MVCMovieContext (DbContextOptions<MVCMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
