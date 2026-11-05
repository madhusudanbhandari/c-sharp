//Behaviourl Design Pattern==specifies how different object interact or communicate with each other

//1.Strategy patterns
//Instead of putting all the algorithns inside the same class and using the conditional statements it basically creates
//separate classes for each algorithm and decides which to execute at runtime

//it has three components
//1.Strategy==common algorithm interface
//2.concrete strategy==specific algorithm implementation
//3.context==uses a selected strategy


// namespace Hello
// {
//     class Program
//     {
//         public interface IPaymentStrategy //Strategy
//         {
//             public Task<bool> ProcessPayment(decimal amount);
//         }

//         public class EsewaStrategy : IPaymentStrategy //concrete strategy
//         {
//             public async Task<bool> ProcessPayment(decimal amount)
//             {
//                 Console.WriteLine($"{amount} processing via esewa");

//                 await Task.Delay(3000);
//                 Console.WriteLine("Complete");
//                 return true;
//             }
//         }


//         public class KhaltiStrategy : IPaymentStrategy //concrete strategy
//         {
//             public async Task<bool> ProcessPayment(decimal amount)
//             {
//                 Console.WriteLine($"{amount} processing via khalti");

//                 await Task.Delay(3000);
//                 Console.WriteLine("Complete");
//                 return true;
//             }
//         }

//         public class PaymentService //context
//         {
//             private readonly IPaymentStrategy _paymentStrategy;

//             public PaymentService(IPaymentStrategy paymentStrategy)
//             {
//                 _paymentStrategy=paymentStrategy;
//             }

//             public async Task<bool> Pay(decimal amount)
//             {
//                 return await _paymentStrategy.ProcessPayment(amount);
//             }
//         }

//         static async Task Main(string[] args)
//         {
//             IPaymentStrategy strategy=new KhaltiStrategy();

//             PaymentService service=new PaymentService(strategy);

//             await service.Pay(5000);
//         }
//     }
// }


//2.Observer pattern
//defines ont-to-many relation between objects
//whenever an object changes state or publishes the event all the registered obeservers are notified automatically...
//publisher==maintains the observer and notifies them
//subscriber===listens to notifications and responds

namespace Hello
{
    class Program
    {
        public class Student
        {
            public int Id{get;set;}
            public string Name{get;set;}=string.Empty;
        }

        public interface IEnrollmentObserver
        {
            public Task UpdateAsync(Student student);
        }

        public class EmailObserver : IEnrollmentObserver
        {
            public async Task UpdateAsync(Student student)
            {
                await Task.Delay(3000);
                Console.WriteLine($"Email sent to {student.Name}");
            }
        }

        public class NotificationObserver : IEnrollmentObserver
        {
            public async Task UpdateAsync(Student student)
            {
                await Task.Delay(3000);
                Console.WriteLine($"Notification sent to {student.Name}");
            }
        }

        public class EnrollmentPublisher
        {
            private readonly List<IEnrollmentObserver> _observers=new();

            public void Subscribe(IEnrollmentObserver observer)
            {
                _observers.Add(observer);
            }

            public void Unsubscribe(IEnrollmentObserver observer)
            {
                _observers.Remove(observer);
            }

            public async Task Notify(Student student)
            {
                foreach(var observer in _observers)
                {
                    await observer.UpdateAsync(student);
                }
            }
        }

        static async Task Main(string[] args)
        {
            EnrollmentPublisher publisher=new EnrollmentPublisher();

            var email=new EmailObserver();
            var notification=new NotificationObserver();

            publisher.Subscribe(email);
            publisher.Subscribe(notification);

            var student=new Student
            {
                Id=1,
                Name="Madhusudan"
            };

            await publisher.Notify(student);
        }
    }
}