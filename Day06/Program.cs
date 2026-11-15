
Developer developer = new Developer();

developer.Name = "Ahmad";
developer.Age = 22;
developer.ProgrammingLanguage = "C#";

developer.ShowInfo();

Console.WriteLine($"Laanguage: {developer.ProgrammingLanguage}");

Notification notification1 = new EmailNotification();
Notification notification2 = new SMSNotification();

notification1.Send();
notification2.Send();

Notification notification3 = new PushNotification();

notification3.Send();

INotificationService service = new ConsoleNotificationService();
service.Send("Your task is completed!");

INotificationService emailService = new EmailNotificationService();

emailService.Send("Hello Ahmad!");

try
{
    int a = 10;
    int b = 0;
    int result = a / b;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: Cannot divide by zero");
}

finally
{
    Console.WriteLine("Programm finished!");
}


int age = 5;

if (age < 0)
{
    throw new ArgumentException("Age cannot be negative!");
}

Console.WriteLine(age);


try
{
    int num1 = 10;
    int num2 = 0;

    Console.WriteLine(num1 / num2);
}

catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero!");
}

finally
{
    Console.WriteLine("Calculation finished.");
}

// 4. LINQ

Console.WriteLine("\n=== LINQ ===");

List<TaskItem> tasks = new()
{
    new TaskItem(1, "Learn C#", 1, false),
    new TaskItem(2, "Build API", 2, false),
    new TaskItem(3, "Learn LINQ", 1, true),
    new TaskItem(4, "Create UI", 3, false),
    new TaskItem(5, "Study OOP", 2, true)
};

// Where

Console.WriteLine("\nPending tasks:");

var pendingTasks = tasks
    .Where(task => !task.IsCompleted);

foreach (var task in pendingTasks)
{
    Console.WriteLine(task.Title);
}


// OrderBy

Console.WriteLine("\nTasks by priority:");

var sortedTasks = tasks
    .OrderBy(task => task.Priority);

foreach (var task in sortedTasks)
{
    Console.WriteLine(
        $"{task.Priority} - {task.Title}");
}


// Select

Console.WriteLine("\nTask titles:");

var titles = tasks
    .Select(task => task.Title);

foreach (var title in titles)
{
    Console.WriteLine(title);
}


// FirstOrDefault

Console.WriteLine("\nFind task:");

var foundTask = tasks
    .FirstOrDefault(task => task.Id == 3);

if (foundTask != null)
{
    Console.WriteLine(foundTask.Title);
}
else
{
    Console.WriteLine("Task not found.");
}


// Any

bool hasCompletedTasks = tasks
    .Any(task => task.IsCompleted);

Console.WriteLine(
    $"\nHas completed tasks: {hasCompletedTasks}");


// 5. EXCEPTIONS

Console.WriteLine("\n=== EXCEPTIONS ===");

try
{
    int number1 = 10;
    int number2 = 0;

    int result = number1 / number2;

    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(
        $"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Calculation finished.");
}


// 6. NULLABLE

Console.WriteLine("\n=== NULLABLE ===");

string? description = null;

if (description != null)
{
    Console.WriteLine(description);
}
else
{
    Console.WriteLine("No description provided.");
}


// 7. ASYNC / AWAIT

Console.WriteLine("\n=== ASYNC / AWAIT ===");

await ShowMessageAsync();

async Task ShowMessageAsync()
{
    Console.WriteLine("Starting async operation...");

    await Task.Delay(1000);

    Console.WriteLine("Async operation completed.");
}