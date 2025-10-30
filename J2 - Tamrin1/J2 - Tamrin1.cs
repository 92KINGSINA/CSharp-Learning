while (true)
{

    int n, m;

    while (true)
    {
        Console.Write("\nEnter first number: ");
        if (int.TryParse(Console.ReadLine(), out n)) break;
        Console.WriteLine("Invalid input.");
    }

    while (true)
    {
        Console.Write("Enter second number: ");
        if (int.TryParse(Console.ReadLine(), out m)) break;
        Console.WriteLine("Invalid input.");
    }

    if (n > m)
    {
        int temp = n;
        n = m;
        m = temp;
    }

    Console.WriteLine("1: Even");
    Console.WriteLine("2: Odd");
    Console.WriteLine("3: Prime");
    Console.WriteLine("4: Palindrome");
    Console.WriteLine("5: Perfect");
    Console.Write("Choose: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            for (int i = n; i <= m; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
            break;

        case "2":
            for (int i = n; i <= m; i++)
                if (i % 2 != 0)
                    Console.WriteLine(i);
            break;

        case "3":
            Console.WriteLine($"\nPrime numbers between {n} and {m}:");
            for (int i = n; i <= m; i++)
                if (IsPrime(i))
                    Console.WriteLine(i);
            break;

        case "4":
            for (int i = n; i <= m; i++)
                if (IsMirror(i))
                    Console.WriteLine(i);
            break;

        case "5":
            for (int i = n; i <= m; i++)
                if (IsPerfect(i))
                    Console.WriteLine(i);
            break;

        default:
            Console.WriteLine("Invalid request.");
            break;
    }

}
bool IsPrime(int num)
{
    if (num < 2) return false;
    if (num == 2) return true;
    if (num % 2 == 0) return false;
    int limit = (int)Math.Sqrt(num);
    for (int i = 3; i <= limit; i += 2)
        if (num % i == 0)
            return false;
    return true;
}

bool IsMirror(int num)
{
    if (num < 0) return false;

    int original = num;
    int reversed = 0;

    while (num > 0)
    {
        int digit = num % 10;
        reversed = reversed * 10 + digit;
        num /= 10;
    }

    return original == reversed;
}

bool IsPerfect(int num)
{
    if (num < 2) return false;
    int sum = 1;
    for (int i = 2; i <= num / 2; i++)
        if (num % i == 0)
            sum += i;
    return sum == num;
}