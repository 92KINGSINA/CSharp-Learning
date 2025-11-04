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

double mainNum = ReadDouble("Enter the reference number: ");

double num1 = ReadDouble("Enter first number: ");
double num2 = ReadDouble("Enter second number: ");
double num3 = ReadDouble("Enter third number: ");

double dist1 = Math.Abs(num1 - mainNum);
double dist2 = Math.Abs(num2 - mainNum);
double dist3 = Math.Abs(num3 - mainNum);

double minDist = Math.Min(dist1, Math.Min(dist2, dist3));

Console.WriteLine("\nNumber(s) closest to the reference:");

if (dist1 == minDist) Console.WriteLine($"First number: {num1}");
if (dist2 == minDist) Console.WriteLine($"Second number: {num2}");
if (dist3 == minDist) Console.WriteLine($"Third number: {num3}");