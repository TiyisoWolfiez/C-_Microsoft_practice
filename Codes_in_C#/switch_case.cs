int dayOfWeek = 3;
string dayName;

switch (dayOfWeek)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    default:
        dayName = "Unknown";
        break;
}

Console.WriteLine(dayName);
