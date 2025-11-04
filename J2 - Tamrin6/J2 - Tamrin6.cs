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

double totalWeightedSum = 0;
double totalWeight = 0;

Console.WriteLine("Enter numbers and their weights.");
Console.WriteLine("Type 'f' to finish.");

while (true)
{
    Console.Write("Enter a number (enter 'f' to finish): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "f") break;

    if (!double.TryParse(input, out double number))
    {
        Console.WriteLine("Invalid number. Try again.");
        continue;
    }

    double weight = ReadDouble("Enter its weight: ");

    totalWeightedSum += number * weight;
    totalWeight += weight;
}

if (totalWeight == 0)
    Console.WriteLine("No weights entered. Cannot calculate weighted average.");
else
{
    double weightedAverage = totalWeightedSum / totalWeight;
    Console.WriteLine($"\nWeighted average: {weightedAverage}");
}
