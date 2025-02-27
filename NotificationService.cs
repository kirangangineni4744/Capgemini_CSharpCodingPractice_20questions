using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    interface INotificationObserver
    {
        void Update(string message);
    }

    class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    class NotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyAll(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
