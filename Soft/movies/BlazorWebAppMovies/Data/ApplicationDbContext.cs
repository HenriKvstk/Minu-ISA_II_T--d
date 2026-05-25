using Abc.Data;
using Abc.Soft.Web.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BlazorWebAppMovies.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Country> Countries { get; set; } = default!;

    }
}