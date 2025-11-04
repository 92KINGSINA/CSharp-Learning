using System;

string LockKeyboradYN()
{
    string input;
    do
    {
        input = Console.ReadKey(true).KeyChar.ToString().ToLower();
    } while (input != "y" && input != "n");
    return input;
}

string GetNext(string path)
{
    switch (path)
    {
        case "": return "Q1: Do you like technology? (y/n)";
        case "y": return "Q2: Do you enjoy coding? (y/n)";
        case "n": return "Q3: Do you prefer outdoors? (y/n)";

        case "yy": return "Q4: Do you like logic problems? (y/n)";
        case "yn": return "Q5: Do you like art? (y/n)";
        case "ny": return "Q6: Do you like sports? (y/n)";
        case "nn": return "Q7: Do you enjoy reading? (y/n)";

        case "yyy": return "Q8: Do you enjoy teamwork? (y/n)";
        case "yyn": return "Q9: Do you prefer working alone? (y/n)";
        case "yny": return "Q10: Do you like design? (y/n)";
        case "ynn": return "Q11: Do you like photography? (y/n)";
        case "nyy": return "Q12: Do you like running? (y/n)";
        case "nyn": return "Q13: Do you like swimming? (y/n)";
        case "nny": return "Q14: Do you like fantasy books? (y/n)";
        case "nnn": return "Q15: Do you like science books? (y/n)";

        case "yyyy": return "Answer1: You might be a software engineer!";
        case "yyyn": return "Answer2: You might be a data analyst!";
        case "yynn": return "Answer3: You might be a researcher!";
        case "ynyy": return "Answer4: You might be a designer!";
        case "ynyn": return "Answer5: You might be a photographer!";
        case "nyyy": return "Answer6: You might be an athlete!";
        case "nyyn": return "Answer7: You might be a coach!";
        case "nnyy": return "Answer8: You might be a writer!";
        case "nnyn": return "Answer9: You might be a teacher!";
        case "nnnn": return "Answer10: You might be a scientist!";

        default: return "End.";
    }
}

string path = "";
Console.WriteLine(GetNext(path));

do
{
    path += LockKeyboradYN();
    Console.WriteLine(GetNext(path));

} while (!GetNext(path).StartsWith("Answer"));

Console.WriteLine("\nThank you for using the Decision System!");
