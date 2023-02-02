using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Domain
{
	public class Order
	{
		public int orderNr { get; private set; }
		public bool isStudentOrder { get; private set; }
		public List<MovieTicket> movieTickets { get; private set; }
        private static readonly JsonSerializerOptions _options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

        public Order(int orderNr, bool isStudentOrder, List<MovieTicket> movieTickets)
		{
			this.orderNr = orderNr;
			this.isStudentOrder = isStudentOrder;
			this.movieTickets = movieTickets;
		}

		public double CalculatePrice()
		{
			int amountOfTickets = this.movieTickets.Count;
			bool secondFree = IsSecondTicketForFree();
			bool groupDiscount = IsGroupDiscount(amountOfTickets);

			return GeneratePrice(secondFree, groupDiscount);
		}

		public void Export(TicketExportFormat exportFormat)
        {
            switch (exportFormat)
            {
				case (TicketExportFormat.PLAINTEXT):
					string[] ticketString = movieTickets.Select(obj => obj.ToString()).ToArray();
					File.WriteAllLines($"./file/plaintext/{this.orderNr}.txt", ticketString);
					break;

				case (TicketExportFormat.JSON):
                    var jsonString = JsonSerializer.Serialize(movieTickets, _options);
                    File.WriteAllText($"./file/json/{this.orderNr}.json", jsonString);
					break;
            }
        }

		private bool IsSecondTicketForFree()
		{
			if (this.isStudentOrder)
			{
				return true;
			}

			foreach (MovieTicket m in movieTickets)
			{
				var dayOfWeek = m.movieScreening.dateAndTime.DayOfWeek;
				if (dayOfWeek == DayOfWeek.Friday || dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
				{
					return false;
				}
			}

			return true;
		}

		private bool IsGroupDiscount(int amountOfTickets)
		{
			if (this.isStudentOrder)
			{
				return false;
			}

			foreach (MovieTicket m in movieTickets)
			{
				var dayOfWeek = m.movieScreening.dateAndTime.DayOfWeek;
				if (dayOfWeek == DayOfWeek.Friday || dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
				{
					return false;
				}
			}

			if (amountOfTickets >= 6)
			{
				return true;
			}

			return false;
		}

		private double GeneratePrice(bool secondTicketFree, bool discount)
		{
			double totalPrice = 0;
			int premiumPrice = isStudentOrder ? 2 : 3;
			bool isFree = false;

			foreach (MovieTicket m in movieTickets)
			{
				if (!secondTicketFree && !isFree)
				{
					totalPrice += m.Price();

					if (m.isPremium)
					{
						totalPrice += premiumPrice;
					}
				}

				isFree = !isFree;
			}

			if (discount)
			{
				totalPrice *= 0.9;
			}

			return totalPrice;
		}
	}
}