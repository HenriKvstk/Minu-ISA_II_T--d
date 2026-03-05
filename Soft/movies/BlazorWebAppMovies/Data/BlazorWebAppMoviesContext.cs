using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Data;
using Microsoft.EntityFrameworkCore;


namespace BlazorWebAppMovies.Data
{
    public class BlazorWebAppMoviesContext : DbContext
    {
        public BlazorWebAppMoviesContext (DbContextOptions<BlazorWebAppMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
