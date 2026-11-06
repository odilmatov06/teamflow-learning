
public class Project
{
    public int Id { set; get; }
    public string Name { set; get; }
    public string Description { set; get; }

    public Project(string name, string description)
    {
        Name = name;
        Description = description;
    }
}