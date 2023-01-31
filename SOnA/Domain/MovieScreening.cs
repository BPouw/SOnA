using System;
namespace Domain
{
    public class MovieScreening
    {
        private DateTime dateAndTime { get; set; }
        private double pricePerSeat { get; set; }
        private Movie movie { get; set; }

        public MovieScreening(DateTime dateAndTime, double pricePerSeat, Movie movie)
        {
            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
            this.movie = movie;
        }
    }
}

