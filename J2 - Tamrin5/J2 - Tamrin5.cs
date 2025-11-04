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

Console.WriteLine("Define the line (ax + by + c = 0):");
double a = ReadDouble("a: ");
double b = ReadDouble("b: ");
double c = ReadDouble("c: ");

int n;
while (true)
{
    Console.Write("Enter number of points: ");
    if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
    Console.WriteLine("Invalid input.");
}

double minDistance = double.MaxValue;
double closestX = 0, closestY = 0;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Point {i}:");
    double x = ReadDouble("  x: ");
    double y = ReadDouble("  y: ");

    double distance = Math.Abs(a * x + b * y + c) / Math.Sqrt(a * a + b * b);

    if (distance < minDistance)
    {
        minDistance = distance;
        closestX = x;
        closestY = y;
    }
}

Console.WriteLine($"\nClosest point to the line: ({closestX}, {closestY})");
Console.WriteLine($"Distance: {minDistance}");