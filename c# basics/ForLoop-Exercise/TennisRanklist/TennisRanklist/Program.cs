int tournaments = int.Parse(Console.ReadLine());
int firstPoints = int.Parse(Console.ReadLine());
int wins = 0;
int sumAvrg = 0;
int sum = firstPoints;

for (int i = 1; i <= tournaments; i++)
{
    string result = Console.ReadLine();
    switch (result)
    {
        case "W":
            sum += 2000;
            sumAvrg += 2000;
            wins++;
            break;
        case "F":
            sum += 1200;
            sumAvrg += 1200;
            break;
        case "SF":
            sum += 720;
            sumAvrg += 720;
            break;
    }
}

int average = sumAvrg / tournaments;

Console.WriteLine($"Final points: {sum}");
Console.WriteLine($"Average points: {average}");
Console.WriteLine($"{(double)wins / tournaments * 100:F2}%");