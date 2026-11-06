

string choice = "";

do
{
    Console.WriteLine();
    Console.WriteLine("========TeamFlow========");
    Console.WriteLine("1. View tasks");
    Console.WriteLine("2. Add task");
    Console.WriteLine("3. Exit");
    Console.WriteLine("==========================");
    Console.Write("Enter your choice: ");

    choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.WriteLine();
            Console.WriteLine("Your tasks:");
            Console.WriteLine("1. Learn C#");
            Console.WriteLine("2. Build Web API");
            Console.WriteLine("3. Learn Angular");

            break;

        case "2":
            Console.WriteLine();
            Console.WriteLine("Task added successfully!");
            break;

        case "3":
            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice");
            break;
    }
}

while (choice != "3");



int priority = 2;

if (priority == 1)
{
    Console.WriteLine("High");
}

else if (priority == 2)
{
    Console.WriteLine("Medium");
}

else if (priority == 3)
{
    Console.WriteLine("Low");
}

else
{
    Console.WriteLine("Invalid priority");
}





for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

int number = 1;
while (number <= 5)
{
    Console.WriteLine(number);
    number++;
}

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}


int userAge = 20;
bool hasPermission = true;

if (userAge >= 18 && hasPermission)
{
    Console.WriteLine("You can complete the task");
}

else
{
    Console.WriteLine("Access denied");
}

bool isCompleted = false;

if (!isCompleted)
{
    Console.WriteLine("Task is not completed.");
}



int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum = sum + i;
}

Console.WriteLine(sum);


