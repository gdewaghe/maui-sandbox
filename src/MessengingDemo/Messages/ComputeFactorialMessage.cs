using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MessengingDemo.Messages
{
    public class ComputeFactorialMessage : RequestMessage<long>
    {
        public int BaseNumber { get; set; }
    }
}
