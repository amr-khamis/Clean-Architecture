using CleanMovie.Application.Contracts;
using CleanMovie.Application.UseCases.BL.Interface;
using CleanMovie.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Application.UseCases.BL
{
   public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public List<Movie> GetMovies()
        {
            return _movieRepository.GetMovies();
        }
    }
}
