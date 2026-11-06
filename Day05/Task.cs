
public class TaskItem
{
    // Properties
    public int Id { get; init; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; private set; }
    public int Priority { get; set; }

    // Constructor
    public TaskItem(string title, int priority)
    {
        Title = title;
        Priority = priority;
        IsCompleted = false;
        Description = string.Empty;
    }

    // Method
    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public void UpdateTitle(string newTitle)
    {
        Title = newTitle;
    }
}

