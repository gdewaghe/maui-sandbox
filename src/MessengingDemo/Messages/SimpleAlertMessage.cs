namespace MessengingDemo.Messages
{
    public class SimpleAlertMessage
    {
        public required string Title { get; set; }
        public required string Message { get; set; }
        public required string Cancel { get; set; }
    }
}
