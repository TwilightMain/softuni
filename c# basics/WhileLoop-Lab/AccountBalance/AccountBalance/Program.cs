string money = Console.ReadLine();
double sum = 0;
while (money != "NoMoreMoney")
{
    double num = double.Parse(money);
    if (num >= 0)
    {
        sum += num;
        money = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {num:f2}");
}
Console.WriteLine($"Total: {sum:f2}");