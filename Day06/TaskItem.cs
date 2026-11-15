
public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Priority { get; set;}
    public bool IsCompleted { get; set; }

    public TaskItem(
        int id,
        string title,
        int priority,
        bool isCompleted
    )
    {
        Id = id;
        Title = title;
        Priority = priority;
        IsCompleted = isCompleted;
    }
}