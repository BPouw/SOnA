namespace Domain;
public class MovieTicket
{
    public int rowNumber { get; private set; }
    public int seatNumber { get; private set; }
    public bool isPremium { get; private set; }
    public MovieScreening movieScreening { get; private set; }

    public MovieTicket(int rowNumber, int seatNumber, bool isPremium, MovieScreening movieScreening)
    {
        this.rowNumber = rowNumber;
        this.seatNumber = seatNumber;
        this.isPremium = isPremium;
        this.movieScreening = movieScreening;
    }
}

