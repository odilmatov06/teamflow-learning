
public class ConsoleNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Notification: {message}");
    }
}