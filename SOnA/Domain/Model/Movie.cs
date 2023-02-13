namespace Domain.Model
{
    public class Movie
    {
        public string title { get; private set; }

        public Movie(string title)
        {
            this.title = title;
        }
    }
}