public class Dashboard
{
    public static void DisplayTasksAndProjects(User user)
    {
        // Logic to display user tasks and projects on a dashboard
        foreach (Project project in user._projectList)
        {
            Console.WriteLine($"Project: {project._title}");
            foreach (Task task in project._tasks)
            {
                Console.WriteLine($"- Task: {task.Title}, Status: {task.Status}, Dead line: {task.Deadline}");
            }
        }
    }
}