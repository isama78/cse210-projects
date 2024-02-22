public class Deadline
{
    public static bool IsNearDeadline(DateTime deadline, int daysLeft)
    {
        // Logic to determine if the deadline is near
        return (deadline - DateTime.Now).TotalDays < daysLeft;
    }
}