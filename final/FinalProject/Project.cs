public class Project
{
    public string _title;
    public List<Task> _tasks;
    

    public Project(string title)
    {
        _title = title;
        _tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        _tasks.Add(task);
    }
}