
List<string> tasks = new List<string>();



void ShowTasks()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available!");
        return;
    }


    Console.WriteLine("======Tasks======");
    foreach (string task in tasks)
    {
        Console.WriteLine(task);
    }
    
}


void AddTask(string taskName)
{
    if (string.IsNullOrWhiteSpace(taskName))
    {
        Console.WriteLine("Task name cannot be empty!");
    }

    else
    {
        tasks.Add(taskName);
        Console.WriteLine("Task added!"); 
    }
   
}

void SearchTask(string taskName)
{
    if (tasks.Contains(taskName))
    {
        Console.WriteLine($"Task found: {taskName}");
    }

    else
    {
        Console.WriteLine("Task not found!");
    }
}


void DeleteTask(string taskName)
{
    bool removed = tasks.Remove(taskName);

    if (removed)
    {
        Console.WriteLine("Task deleted!");
    }

    else
    {
        Console.WriteLine("Task not found!");
    }
}



string choice = "";

do
{
    Console.WriteLine();
    Console.WriteLine("========TASK MANAGER========");
    Console.WriteLine("1. Show tasks");
    Console.WriteLine("2. Add Task");
    Console.WriteLine("3. Search Task");
    Console.WriteLine("4. Delete Task");
    Console.WriteLine("5. Exit");

    choice = (Console.ReadLine() ?? "").Trim();

    switch (choice)
    {
        case "1":
            Console.WriteLine();
            ShowTasks();
            break;


        case "2":
            Console.WriteLine();
            Console.Write("Enter task to add: ");
            string add = Console.ReadLine() ?? "";
            AddTask(add);
            break;

        case "3":
            Console.WriteLine();
            Console.Write("Enter task for search: ");
            string search = Console.ReadLine() ?? "";
            SearchTask(search);
            break;

        case "4":
            Console.WriteLine();
            Console.Write("Enter task to delete: ");
            string delete = Console.ReadLine() ?? "";
            DeleteTask(delete);
            break;

        case "5":
            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice!");
            break;
    }
}
while(choice != "5");