using System;
namespace Domain
{
    public class Order
    {
        private int orderNr { get; set; }
        private bool isStudentOrder { get; set; }

        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
        }
    }
}

