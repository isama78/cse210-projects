public class NormalUser : User
{
    public NormalUser(string username, string email) : base(username, email)
    {
        _userName = username;
        _email = email;
        _projectList = new List<Project>();
        _assignedTasks = new List<Task>();
    }

    public override void CreateTask(string projectTitle, string taskTitle, string taskDescription, DateTime deadline)
    {
        Project project = _projectList.Find(p => p._title == projectTitle);
        if (project != null)
        {
            Task newTask = new Task(taskTitle, taskDescription, deadline);
            project._tasks.Add(newTask);
        }
        else
        {
            Console.WriteLine("Project doesn´t exsists for this user.");
        }
    }
}