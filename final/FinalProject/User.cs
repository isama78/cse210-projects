public abstract class User
{
    public string _userName;
    public string _email;
    public List<Project> _projectList;
    public List<Task> _assignedTasks;

    public User(string userName, string email)
    {
        _userName = userName;
        _email = email;
    }

    public abstract void CreateTask(string projectTitle, string taskTitle, string taskDescription, DateTime deadline);
}