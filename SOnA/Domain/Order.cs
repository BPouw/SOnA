using System;
namespace Domain
{
    public class Order
    {
        public int orderNr { get; private set; }
        public bool isStudentOrder { get; private set; }
        public List<MovieTicket> movieTickets { get; private set; }

        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
        }

        public double CalculatePrice()
        {
            int amountOfTickets = this.movieTickets.Count;
            bool secondFree = isSecondTicketForFree();
            bool groupDiscount = isGroupDiscount(amountOfTickets);


            return 0;
        }

        private bool isSecondTicketForFree()
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

        private bool isGroupDiscount(int amountOfTickets)
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
    }
}

