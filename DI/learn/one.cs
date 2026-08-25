

// //Problem without the dependency injection

// //1.Tight Coupling


// UserRegistration user=new();
// user.RegisterUser("madhu@gmail.com");

// OrderBooking order=new();
// order.BookOrder("madhu@gmail.com");
// public class EmailService
// {
//     public void SendEmail(string to, string subject, string body)
//     {
//         Console.WriteLine($"This mail is sent to{to} with subject {subject} and body {body}");

//     }
// }

// public class UserRegistration
// {
//     private EmailService _emailService;
    
//     public UserRegistration()
//     {
//         _emailService=new EmailService();
//     }

//     public void RegisterUser(string email)
//     {
//         _emailService.SendEmail(email,"Registration Successfulll","User is registered successfully");

//     }
// }

// public class OrderBooking
// {
//     private EmailService _emailService;

//     public OrderBooking()
//     {
//         _emailService=new EmailService();
//     }

//     public void BookOrder(string email)
//     {
//         _emailService.SendEmail(email,"Order Booking","This order is successfully booked");
//     }
// }


// //2. You cant test the methods like RegisterUser or BookOrder in isolation , 
// //you cant avoid sending the actual email, because the OrderBooking insists on creating 
// //the new EmailService Everytime


// //3. You cant change the behaviour without editing this class
// //if you want to add or replace any functionality you have to change this class

// //4.It doesnt scale as your app grows, poor flexibility and the maintenance


// //Thumb rule: A class should not be responsible for creating the things it depends on
