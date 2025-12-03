using CommunityToolkit.Mvvm.Messaging;
using MessengingDemo.Messages;
using MessengingDemo.Services.Interfaces;

namespace MessengingDemo.Services
{
    public class FactorialService : IFactorialService
    {
        public FactorialService()
        {
            WeakReferenceMessenger.Default.Register<ComputeFactorialMessage>(this, (r, m) =>
            {
                try
                {
                    m.Reply(GetFactorial(m.BaseNumber));
                }
                catch
                {
                    m.Reply(-1);
                }
            });
        }

        public long GetFactorial(int number)
        {
            return number switch
            {
                < 0 or > 20 => Error(),
                0 => 1,
                _ => number * GetFactorial(number - 1)
            };
        }

        private static long Error()
        {
            var message = new SimpleAlertMessage
            {
                Title = "Error",
                Message = "Cannot compute factorial for the given number. Please provide a number between 0 and 20.",
                Cancel = "Ok"
            };
            WeakReferenceMessenger.Default.Send(message);
            return -1;
        }
    }
}
