int num = int.Parse(Console.ReadLine());
int newNum = int.Parse(Console.ReadLine());
int sum = 0;
while (true)
{
    sum += newNum;
    if (sum >= num)
    {
        break;
    }
    newNum = int.Parse(Console.ReadLine());
}
Console.WriteLine(sum);