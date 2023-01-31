using System;
using Domain;

namespace DomainServices.IRepository
{
    public interface IMovieScreeningRepository
    {
        IEnumerable<MovieScreening> getAllMovieScreenings();
        MovieScreening getMovieScreening(DateTime dateTime, Movie movie);
    }
}

