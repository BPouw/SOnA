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
        public void test_gives_discount_when_in_group()
        {
            //Arrange
            Order or = fake.GetGroupDefaultOrder();

            //Act
            double price = or.CalculatePrice();

            //Assert
            Assert.Equal(10, price);
            
        }
    }
}

