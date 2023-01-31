namespace Domain;
public class MovieTicket
{
    private int rowNumber { get; set; }
    private int seatNumber { get; set; }
    private bool isPremium { get; set; }
    private MovieScreening movieScreening { get; set; }

    public MovieTicket(int rowNumber, int seatNumber, bool isPremium, MovieScreening movieScreening)
    {
        this.rowNumber = rowNumber;
        this.seatNumber = seatNumber;
        this.isPremium = isPremium;
        this.movieScreening = movieScreening;
    }
}

