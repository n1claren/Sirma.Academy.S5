int month = int.Parse(Console.ReadLine());

int daysInMonth = 0;

switch (month)
{
    case 1: 
    case 3: 
    case 5:
    case 7:
    case 8:
    case 10: 
    case 12:
        daysInMonth = 31;
        break;

    case 4: 
    case 6: 
    case 9: 
    case 11:
        daysInMonth = 30;
        break;

    case 2: 
        daysInMonth = 28; 
        break;

    default:
        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
        return;
}


Console.WriteLine(daysInMonth);