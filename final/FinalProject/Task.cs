public enum TaskStatus
{
    Pending,
    InProgress,
    Completed
}

public class Task
{
    public string Title;
    public string Description;
    public TaskStatus Status;
    public DateTime Deadline;
    public User AssignedUser;

    public Task(string title, string description, DateTime deadline)
    {
        Title = title;
        Description = description;
        Deadline = deadline;
        Status = TaskStatus.Pending;
    }

    public void AssignToUser(User user)
    {
        AssignedUser = user;
    }
}