using System;
namespace Domain
{
    public class Order
    {
        public int orderNr { get; private set; }
        public bool isStudentOrder { get; private set; }
        public List<MovieTicket> movieTickets { get; private set; }

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

            return GeneratePrice(secondFree, groupDiscount, amountOfTickets);
        }

        private bool IsSecondTicketForFree()
        {
            if (this.isStudentOrder)
            {
                return true;
            }

            foreach(MovieTicket m in movieTickets)
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

        private double GeneratePrice(bool secondTicketFree, bool discount, int amountOfTickets)
        {
            double totalPrice = 0;

            // second ticket free logica

            if (!secondTicketFree)
            {
                foreach (MovieTicket m in movieTickets)
                {
                    totalPrice += m.Price();
                }
            } else
            {
                bool isEven = false;

                foreach (MovieTicket m in movieTickets)
                {
                    if (!isEven)
                    {
                        totalPrice += m.Price();
                    }

                    isEven = !isEven;
                }
            }

            //premium calculation

            foreach(MovieTicket m in movieTickets)
            {
                if (m.isPremium)
                {
                    if (isStudentOrder)
                    {
                        totalPrice += 2;
                    }
                    else
                    {
                        totalPrice += 3;
                    }
                }
            }


            // discount calculation

            if (discount) {
                totalPrice = totalPrice * 0.9;
            }

            return totalPrice;
        }
    }
}