int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());
int tax = 0;
for (int i = 1; i <= tabs; i++)
{
    string website = Console.ReadLine();
    switch (website)
    {
        case "Facebook":
            tax += 150;
            break;
        case "Instagram":
            tax += 100;
            break;
        case "Reddit":
            tax += 50;
            break;
    }
}
if (tax >= salary)
{
    Console.WriteLine($"You have lost your salary.");
}
else if (tax < salary)
{
    int afterTax = salary - tax;
    Console.WriteLine(afterTax);
}