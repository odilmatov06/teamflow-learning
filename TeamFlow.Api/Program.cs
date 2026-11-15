
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/status", () => new {application = "TeamFlow", status = "running"});

var projects = new List<ProjectItem>
{
    new(1, "TeamFlow", "Task and management system"),
    new(2, "Portfolio", "Personal portfolio website"),
    new(3, "Learning notes", "Notes from the 30-days program")
};

app.MapGet("/api/projects", () => projects);
app.Run();

record ProjectItem(int Id, string Name, string Description);