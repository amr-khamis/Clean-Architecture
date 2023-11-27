using CleanMovie.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Application.UseCases.BL.Interface
{
   public interface IMovieService
    {
        List<Movie> GetMovies();
    }
}
