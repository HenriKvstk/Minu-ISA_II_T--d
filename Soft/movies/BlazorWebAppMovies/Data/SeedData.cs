using Microsoft.EntityFrameworkCore;
using Abc.Data;

namespace BlazorWebAppMovies.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>());

        if (context == null || context.Movie == null)
        {
            throw new NullReferenceException(
                "Null BlazorWebAppMoviesContext or Movie DbSet");
        }

        if (context.Movie.Any())
        {
            return;
        }

        context.Movie.AddRange(
            new Movie
            {
                Name = "Mad Max",
                ValidFrom = new DateTime(1979, 4, 12),
                Genre = "Sci-fi (Cyberpunk)",
                Price = 2.51M,
                Rating = "R",
            },
            new Movie
            {
                Name = "The Road Warrior",
                ValidFrom = new DateTime(1981, 12, 24),
                Genre = "Sci-fi (Cyberpunk)",
                Price = 2.78M,
                Rating = "R",
            },
            new Movie
            {
                Name = "Mad Max: Beyond Thunderdome",
                ValidFrom = new DateTime(1985, 7, 10),
                Genre = "Sci-fi (Cyberpunk)",
                Price = 3.55M,
                Rating = "PG-13",
            },
            new Movie
            {
                Name = "Mad Max: Fury Road",
                ValidFrom = new DateTime(2015, 5, 15),
                Genre = "Sci-fi (Cyberpunk)",
                Price = 8.43M,
                Rating = "R",
            },
            new Movie
            {
                Name = "Furiosa: A Mad Max Saga",
                ValidFrom = new DateTime(2024, 5, 24),
                Genre = "Sci-fi (Cyberpunk)",
                Price = 13.49M,
                Rating = "R",
            });

        context.SaveChanges();
    }
}