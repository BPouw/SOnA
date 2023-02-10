using Domain.Model;

namespace Test
{
	public class Fake
	{
		// movie
		private Movie GetSomeMovie()
		{
			return new Movie("James Bond");

		}

		//movie screening
		private MovieScreening GetWeekdayMovieScreening()
		{
			Movie mov = GetSomeMovie();
			return new MovieScreening(new DateTime(2023, 2, 1), 10, mov);
		}

		private MovieScreening GetWeekendMovieScreening()
		{
			Movie mov = GetSomeMovie();
			return new MovieScreening(new DateTime(2023, 2, 5), 10, mov);
		}

		// movie ticket
		private MovieTicket GetPremiumWeekdayMovieTicket()
		{
			MovieScreening movieScreening = GetWeekdayMovieScreening();
			return new MovieTicket(12, 10, true, movieScreening);
		}

		private MovieTicket GetDefaultWeekdayMovieTicket()
		{
			MovieScreening movieScreening = GetWeekdayMovieScreening();
			return new MovieTicket(12, 10, false, movieScreening);
		}

		private MovieTicket GetPremiumWeekendMovieTicket()
		{
			MovieScreening movieScreening = GetWeekendMovieScreening();
			return new MovieTicket(12, 10, true, movieScreening);
		}

		private MovieTicket GetDefaultWeekendMovieTicket()
		{
			MovieScreening movieScreening = GetWeekendMovieScreening();
			return new MovieTicket(12, 10, false, movieScreening);
		}

		// orders
		public Order GetPremiumStudentWeekendOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumWeekendMovieTicket());

			return new Order(1, true, movieTickets);
		}

		public Order GetPremiumDefaultWeekendOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumWeekendMovieTicket());

			return new Order(1, false, movieTickets);
		}

		public Order GetPremiumStudentWeekdayOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumWeekdayMovieTicket());

			return new Order(1, true, movieTickets);
		}

		public Order GetPremiumDefaultWeekdayOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumWeekdayMovieTicket());

			return new Order(1, false, movieTickets);
		}

		public Order GetGroupDefaultWeekendOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetDefaultWeekendMovieTicket());
			movieTickets.Add(GetDefaultWeekendMovieTicket());
			movieTickets.Add(GetDefaultWeekendMovieTicket());
			movieTickets.Add(GetDefaultWeekendMovieTicket());
			movieTickets.Add(GetDefaultWeekendMovieTicket());
			movieTickets.Add(GetDefaultWeekendMovieTicket());

			return new Order(1, false, movieTickets);
		}

		public Order GetGroupPremiumWeekendOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumWeekendMovieTicket());
			movieTickets.Add(GetPremiumWeekendMovieTicket());
			movieTickets.Add(GetPremiumWeekendMovieTicket());
			movieTickets.Add(GetPremiumWeekendMovieTicket());
			movieTickets.Add(GetPremiumWeekendMovieTicket());
			movieTickets.Add(GetPremiumWeekendMovieTicket());

			return new Order(1, false, movieTickets);
		}

		public Order GetGroupDefaultWeekdayOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetDefaultWeekdayMovieTicket());
			movieTickets.Add(GetDefaultWeekdayMovieTicket());
			movieTickets.Add(GetDefaultWeekdayMovieTicket());
			movieTickets.Add(GetDefaultWeekdayMovieTicket());
			movieTickets.Add(GetDefaultWeekdayMovieTicket());
			movieTickets.Add(GetDefaultWeekdayMovieTicket());

			return new Order(1, false, movieTickets);
		}

		public Order GetGroupPremiumWeekdayOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumWeekdayMovieTicket());
			movieTickets.Add(GetPremiumWeekdayMovieTicket());
			movieTickets.Add(GetPremiumWeekdayMovieTicket());
			movieTickets.Add(GetPremiumWeekdayMovieTicket());
			movieTickets.Add(GetPremiumWeekdayMovieTicket());
			movieTickets.Add(GetPremiumWeekdayMovieTicket());

			return new Order(1, false, movieTickets);

		}


	}
}

