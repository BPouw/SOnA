namespace Domain.Model
{
    public class MovieScreening
    {
        public DateTime dateAndTime { get; private set; }
        public decimal pricePerSeat { get; private set; }
        public Movie movie { get; private set; }

        public MovieScreening(DateTime dateAndTime, decimal pricePerSeat, Movie movie)
        {
            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
            this.movie = movie;
        }
    }
}

