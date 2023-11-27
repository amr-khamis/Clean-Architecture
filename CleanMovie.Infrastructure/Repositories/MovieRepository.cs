using CleanMovie.Application.Contracts;
using CleanMovie.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Id = 1 , Name = "The Gang of Four" , Cost = 100000 },
                new Movie() { Id = 2 , Name = "Clean Architecture" , Cost = 1000000 }
            };
        }
    }
}
