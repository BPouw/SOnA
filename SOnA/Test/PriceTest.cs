
// using Domain.Model;

// namespace Test
// {
//     public class PaymentTest
//     {
//         readonly Fake fake;

// 		public PaymentTest()
// 		{
// 			 fake = new Fake();
// 		}


//         [Fact]
//         public void Group_Does_Not_Get_Discount_On_Weekends()
//         {
//             //Arrange
//             Order or = fake.GetGroupDefaultWeekendOrder();

//             //Act
//             double price = or.CalculatePrice();

//             //Assert
//             Assert.Equal(60, price);

//         }

// 		[Fact]
//         public void Group_Does_Get_Discount_And_Half_Ticket_Off_Outside_Weekends()
// 		{
//             //Arrange
//             Order or = fake.GetGroupDefaultWeekdayOrder();

//             //Act
//             double price = or.CalculatePrice();

//             //Assert
//             Assert.Equal(27, price);
// 		}

// 		[Fact]
//         public void Premium_Non_Student_Adds_Correct_Fee()
// 		{
//             //Arrange
//             Order or = fake.GetPremiumDefaultWeekendOrder();

//             //Act
//             double price = or.CalculatePrice();

//             //Assert
//             Assert.Equal(13, price);
// 		}

// 		[Fact]
//         public void Premium_Student_Adds_Correct_Fee()
// 		{
//             //Arrange
//             Order or = fake.GetPremiumStudentWeekendOrder();

//             //Act
//             double price = or.CalculatePrice();

//             //Assert
//             Assert.Equal(12, price);
// 		}


//     }
// }

