using CleanMovie.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Application.Contracts
{
   public interface IMovieRepository
    {
        List<Movie> GetMovies();
    }
}
