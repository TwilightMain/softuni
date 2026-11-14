string number = Console.ReadLine();
int max = int.MinValue;
while (number != "Stop")
{
    int n =  int.Parse(number);
    if (n > max)
    {
        max = n;
    }
    number = Console.ReadLine();
}

Console.WriteLine(max);