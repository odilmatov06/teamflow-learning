string projectName = "TeamFlow";
Console.WriteLine(projectName);

projectName = "TeamFlow Management System";
Console.WriteLine(projectName);

int taskCount = 10;
Console.WriteLine(taskCount);

string taskTitle = "Learning C# variables";
Console.WriteLine(taskTitle);

int completedTasks = 8;
Console.WriteLine(completedTasks);  

double estimatedHours = 3.5;
Console.WriteLine(estimatedHours);

decimal projectBudget = 2500.50m;
decimal taskPrice = 125.75m;
Console.WriteLine(projectBudget);
Console.WriteLine(taskPrice);

long totalTasks = 5000000000L;
Console.WriteLine(totalTasks);

char priorityCode = 'H';
Console.WriteLine(priorityCode);

string priorityName = "High";
Console.WriteLine(priorityName);

bool isTaskCompleted = false;
bool isUserActive = true;
Console.WriteLine(isTaskCompleted);
Console.WriteLine(isUserActive);

var userName = "Ali";
var isActive = true;
var totalTask = 15;
Console.WriteLine(userName);
Console.WriteLine(isActive);
Console.WriteLine(totalTask);

int a = 10;
int b = 5;
int result = a + b;
Console.WriteLine(result);

int total = 20;
int completed = 8;
int pending = total - completed;

int newTask = 3;

total = total + newTask;

double rate = ((double)completed * 100) / total;

Console.WriteLine($"Total tasks: {total}");
Console.WriteLine($"Completed tasks: {completed}");
Console.WriteLine($"Pending tasks: {pending}");
Console.WriteLine($"Completion rate: {rate:F2}%");

Console.Write("Enter task count: ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int taskCounts))
{
    Console.WriteLine($"Task count: {taskCounts}");
}
else
{
    Console.WriteLine("Please enter a valid number");
}