namespace PaymentContext.Shared.Nofitications
{
    public sealed class Notification 
    {
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; private set; }
        public string Message { get; private set; }
        
    }
}