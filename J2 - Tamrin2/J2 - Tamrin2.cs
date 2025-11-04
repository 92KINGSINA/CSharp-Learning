while (true)
{
    int n, m;

    while (true)
    {
        Console.Write("\nEnter first number: ");
        if (int.TryParse(Console.ReadLine(), out n)) break;
        Console.WriteLine("Invalid.");
    }

    while (true)
    {
        Console.Write("Enter second number: ");
        if (int.TryParse(Console.ReadLine(), out m)) break;
        Console.WriteLine("Invalid.");
    }

    if (n > m)
    {
        int temp = n; n = m; m = temp;
    }

    Console.WriteLine("\n1: Goldbach");
    Console.WriteLine("2: Lemoine");
    Console.WriteLine("3: Both");
    Console.Write("Choose: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            for (int i = n; i <= m; i++)
                if (i % 2 == 0 && i > 2) Goldbach(i);
            break;
        case "2":
            for (int i = n; i <= m; i++)
                if (i % 2 != 0 && i > 5) Lemoine(i);
            break;
        case "3":
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0 && i > 2) Goldbach(i);
                else if (i % 2 != 0 && i > 5) Lemoine(i);
            }
            break;
        default:
            Console.WriteLine("Invalid.");
            break;
    }

    Console.WriteLine("\nPress any key...");
    Console.ReadKey();
    Console.Clear();
}

bool IsPrime(int num)
{
    if (num < 2) return false;
    if (num == 2) return true;
    if (num % 2 == 0) return false;
    int limit = (int)Math.Sqrt(num);
    for (int i = 3; i <= limit; i += 2)
        if (num % i == 0) return false;
    return true;
}

void Goldbach(int num)
{
    Console.WriteLine($"\nEven {num}:");
    bool found = false;
    for (int i = 2; i <= num / 2; i++)
    {
        if (IsPrime(i) && IsPrime(num - i))
        {
            Console.WriteLine($"  {num} = {i} + {num - i}");
            found = true;
        }
    }
    if (!found) Console.WriteLine("  No pair!");
}

void Lemoine(int num)
{
    Console.WriteLine($"\nOdd {num}:");
    bool found = false;
    for (int p = 2; p < num; p++)
    {
        if (!IsPrime(p)) continue;
        int q = (num - p) / 2;
        if ((num - p) % 2 == 0 && IsPrime(q))
        {
            Console.WriteLine($"  {num} = {p} + 2×{q}");
            found = true;
        }
    }
    if (!found) Console.WriteLine("  No solution!");
}