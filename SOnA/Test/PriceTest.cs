using System;
using Domain;
namespace Test
{
    public class PaymentTest
    {
        readonly Fake fake;

		public PaymentTest()
		{
			 fake = new Fake();
		}


        [Fact]
        public void Group_does_not_get_Discount_on_Weekends()
        {
            //Arrange
            Order or = fake.GetGroupDefaultOrder();

            //Act
            double price = or.CalculatePrice();

            //Assert
            Assert.Equal(60, price);

        }
    }
}

