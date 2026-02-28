var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorWebAppMovies>("blazorwebappmovies");

builder.Build().Run();
