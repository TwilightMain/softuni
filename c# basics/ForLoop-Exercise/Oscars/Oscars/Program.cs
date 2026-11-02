string name = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int judges = int.Parse(Console.ReadLine());
double sum = pointsFromAcademy;

for (int i = 1; i <= judges; i++)
{
    string JudgeName = Console.ReadLine();
    int length = JudgeName.Length;
    double pointsFromJudge = double.Parse(Console.ReadLine());
    sum = sum + ((length * pointsFromJudge) / 2);
    if (sum > 1250.5)
    {
        Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {sum:f1}!");
        return;
    }
}

if (sum < 1250.5)
{
    double difference = 1250.5 - sum;
    Console.WriteLine($"Sorry, {name} you need {difference:f1} more!");
}