int groups = int.Parse(Console.ReadLine());
int sum = 0;
int Musala = 0;
int Monblan = 0;
int Kilimandjaro = 0;
int K2 = 0;
int Everest = 0;

for (int i = 1; i <= groups; i++)
{
    int people  = int.Parse(Console.ReadLine());
    sum += people;
    switch (people)
    {
        case <= 5:
            Musala += people;
            break;
        case >= 6 and <= 12:
            Monblan += people;
            break;
        case >= 13 and <= 25:
            Kilimandjaro += people;
            break;
        case >= 26 and <= 40:
            K2 += people;
            break;
        case >= 41:
            Everest += people;
            break;
    }
}

Console.WriteLine($"{(double) Musala / sum * 100:F2}%");
Console.WriteLine($"{(double) Monblan / sum * 100:F2}%");
Console.WriteLine($"{(double) Kilimandjaro / sum * 100:F2}%");
Console.WriteLine($"{(double) K2 / sum * 100:F2}%");
Console.WriteLine($"{(double) Everest / sum * 100:F2}%");