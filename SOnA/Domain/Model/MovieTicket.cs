namespace Domain.Model;
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

    public decimal Price()
    {
        return this.movieScreening.pricePerSeat;
    }

    public override string ToString()
    {
        return $"{this.rowNumber},{this.seatNumber},is premium: {isPremium}, movie: {this.movieScreening}";
    }


}

