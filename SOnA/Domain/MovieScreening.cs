using System;
namespace Domain
{
    public class MovieScreening
    {
        public DateTime dateAndTime { get; private set; }
        public double pricePerSeat { get; private set; }
        public Movie movie { get; private set; }

        public MovieScreening(DateTime dateAndTime, double pricePerSeat, Movie movie)
        {
            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
            this.movie = movie;
        }
    }
}

