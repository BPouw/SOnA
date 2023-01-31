using System;
using Domain;

namespace DomainServices.IRepository
{
    public interface IMovieTicketRepository
    {
        IEnumerable<MovieTicket> GetMovieTickets();
        MovieTicket getMovieTicket(int rowNumber, int seatNumber, MovieScreening movieScreening);
    }
}

