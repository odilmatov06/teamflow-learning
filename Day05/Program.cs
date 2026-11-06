

TaskItem task1 = new TaskItem("Learn C#", 1)
{
    Id = 1,
    Description = "Learning OOP Fundamentals"
};

TaskItem task2 = new TaskItem("Learn ASP.Core", 2)
{
    Id = 2,
    Description = "Prepare for Web API"
};

TaskItem task3 = new TaskItem("Build TeamFlow", 1)
{
    Id = 3,
    Description = "Create a managment system"
};


//Complete one task
task1.MarkAsCompleted();

//Update one title
task3.UpdateTitle("BUILD TeamFlow");


//Try to change ID
//task1.Id = 5;

// Display tasks
Console.WriteLine();
Console.WriteLine("======TeamFlow Tasks======");
Console.WriteLine($"ID: {task1.Id}");
Console.WriteLine($"Title: {task1.Title}");
Console.WriteLine($"Description: {task1.Description}");
Console.WriteLine($"Completed: {task1.IsCompleted}");
Console.WriteLine($"Priority: {task1.Priority}");

Console.WriteLine();

Console.WriteLine($"ID: {task2.Id}");
Console.WriteLine($"Title: {task2.Title}");
Console.WriteLine($"Description: {task2.Description}");
Console.WriteLine($"Priority: {task2.Priority}");
Console.WriteLine($"Completed: {task2.IsCompleted}");

Console.WriteLine();

Console.WriteLine($"ID: {task3.Id}");
Console.WriteLine($"Title: {task3.Title}");
Console.WriteLine($"Description: {task3.Description}");
Console.WriteLine($"Priority: {task3.Priority}");
Console.WriteLine($"Completed: {task3.IsCompleted}");

Console.WriteLine();


// Creating Project options
Project project1 = new Project(
    "TeamFlow",
    "Task Managment System"
)
{
    Id = 1
};

Project project2 = new Project(
    "Learning Platform",
    "Online Education Platform"
)
{
    Id = 2
};

// Display projects
Console.WriteLine();
Console.WriteLine("====== TeamFlow Projects ======");
Console.WriteLine($"ID: {project1.Id}");
Console.WriteLine($"Name: {project1.Name}");
Console.WriteLine($"Description: {project1.Description}");

Console.WriteLine();

Console.WriteLine($"ID: {project2.Id}");
Console.WriteLine($"Name: {project2.Name}");
Console.WriteLine($"Description: {project2.Description}");
