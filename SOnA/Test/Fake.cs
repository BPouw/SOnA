using System;
using Domain;

namespace Test
{
	public class Fake
	{

		public Movie GetSomeMovie()
		{
			return new Movie("James Bond");

		}

		public MovieScreening GetWeekdayMovieScreening()
		{
			Movie mov = GetSomeMovie();
			return new MovieScreening(new DateTime(2023, 2, 1), 10, mov);
		}

		public MovieScreening GetWeekendMovieScreening()
		{
			Movie mov = GetSomeMovie();
			return new MovieScreening(new DateTime(2023, 2, 5), 10, mov);
		}

		public MovieTicket GetPremiumMovieTicket()
		{
			MovieScreening movieScreening = GetWeekdayMovieScreening();
			return new MovieTicket(12, 10, true, movieScreening);
		}

		public MovieTicket GetDefaultMovieTicket()
		{
			MovieScreening movieScreening = GetWeekendMovieScreening();
			return new MovieTicket(12, 10, false, movieScreening);
		}

		public Order GetPremiumStudentOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetDefaultMovieTicket());

			return new Order(1, true, movieTickets);
		}

		public Order GetPremiumDefaultOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumMovieTicket());

			return new Order(1, true, movieTickets);
		}

		public Order GetGroupDefaultOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetDefaultMovieTicket());
			movieTickets.Add(GetDefaultMovieTicket());
			movieTickets.Add(GetDefaultMovieTicket());
			movieTickets.Add(GetDefaultMovieTicket());
			movieTickets.Add(GetDefaultMovieTicket());
			movieTickets.Add(GetDefaultMovieTicket());

			return new Order(1, false, movieTickets);
		}

		public Order GetGroupPremiumOrder()
		{
			List<MovieTicket> movieTickets = new List<MovieTicket>();
			movieTickets.Add(GetPremiumMovieTicket());
			movieTickets.Add(GetPremiumMovieTicket());
			movieTickets.Add(GetPremiumMovieTicket());
			movieTickets.Add(GetPremiumMovieTicket());
			movieTickets.Add(GetPremiumMovieTicket());
			movieTickets.Add(GetPremiumMovieTicket());

			return new Order(1, false, movieTickets);
		}


	}
}

