public class AdminUser : User
{
    public AdminUser(string username, string email) : base(username, email)
    {
        _userName = username;
        _email = email;
        _projectList = new List<Project>();
        _assignedTasks = new List<Task>();
    }

    public override void CreateTask(string projectTitle, string taskTitle, string taskDescription, DateTime deadline)
    {
        // Search the project by title
        Project project = _projectList.Find(p => p._title == projectTitle);
        if (project != null)
        {
            // Create a new task and add it to the project
            Task newTask = new Task(taskTitle, taskDescription, deadline);
            project._tasks.Add(newTask);
        }
        else
        {
            Console.WriteLine("Project doesn´t exsists for this user.");
        }
    }

    public void AddAssignedTask(string projectTitle, Task task)
    {
        Project project = _projectList.Find(p => p._title == projectTitle);
        if (project != null)
        {
            _assignedTasks.Add(task); // Add the task to the assigned task list
        }
        else
        {
            Console.WriteLine("Project doesn´t exsists for this user.");
        }
    }

    public void AddAssignedProject(Project project)
    {
        _projectList.Add(project); // Add the task to the assigned project
    }
}