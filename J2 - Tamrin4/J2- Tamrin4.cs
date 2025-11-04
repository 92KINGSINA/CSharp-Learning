double ReadDouble(string prompt)
{
    double value;
    while (true)
    {
        Console.Write(prompt);
        if (double.TryParse(Console.ReadLine(), out value)) break;
        Console.WriteLine("Invalid input.");
    }
    return value;
}

Console.WriteLine("Enter coordinates of P1:");
double x1 = ReadDouble("x1: ");
double y1 = ReadDouble("y1: ");

Console.WriteLine("Enter coordinates of P2:");
double x2 = ReadDouble("x2: ");
double y2 = ReadDouble("y2: ");

Console.WriteLine("Enter coordinates of P3:");
double x3 = ReadDouble("x3: ");
double y3 = ReadDouble("y3: ");

if (x2 - x1 == 0)
{
    if (x3 == x1)
        Console.WriteLine("P3 is on the line through P1 and P2.");
    else
        Console.WriteLine("P3 isn't on the line through P1 and P2.");
}
else
{
    double m = (y2 - y1) / (x2 - x1);
    if (Math.Abs(y3 - (y1 + m * (x3 - x1))) < 1e-9)
        Console.WriteLine("P3 is on the line through P1 and P2.");
    else
        Console.WriteLine("P3 isn't on the line through P1 and P2.");
}
