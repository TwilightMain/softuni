string number = Console.ReadLine();
int min = int.MaxValue;
while (number != "Stop")
{
    int n =  int.Parse(number);
    if (n < min)
    {
        min = n;
    }
    number = Console.ReadLine();
}

Console.WriteLine(min);