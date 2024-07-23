

string userName = "";

switch (userName)
{
    case null:
        Console.WriteLine("The username can't be null!");
        break;
    case "":
        Console.WriteLine("Please enter something for the username.");
        break;
    case "root":
        Console.WriteLine("You're logged in!");
        break;
    default:
        Console.WriteLine("Invalid login attempt. Please try again");
        break;
}

if (z > 0)
{
    Console.WriteLine("z is greater than 0");
}
else if (z < 0)
{
    Console.WriteLine("z is less than 0");
}
else
{
    Console.WriteLine("z is not greater than 0");
}



int a = 10;
int b = 20;


if (a == b || b > a)
{
    Console.WriteLine(1);
}
else if (a >= b + 10)
{
    Console.WriteLine(2);
}
else if (a != b)
{
    Console.WriteLine(3);
}
else
{
    Console.WriteLine(4);
}



string dayOfTheWeek = "Saturday";
switch (dayOfTheWeek)
{
    case "Sunday":
        Console.WriteLine("Today is Sunday");
        break;
    case "Monday":
        Console.WriteLine("Today is Monday");
        break;
    case "Tuesday":
        Console.WriteLine("Today is Tuesday");
        break;
    case "Wednesday":
        Console.WriteLine("Today is Wednesday");
        break;
    case "Thursday":
        Console.WriteLine("Today is Thursday");
        break;
    case "Friday":
        Console.WriteLine("Today is Friday");
        break;
    case "Saturday":
        Console.WriteLine("Todays is Saturday");
        break;
    default:
        Console.WriteLine("This is not a day of the week");
        break;
}








