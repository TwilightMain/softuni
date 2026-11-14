string name = Console.ReadLine();
int count = 1;
double sum = 0;
double avr;
while (count <= 12)
{
    double grade = double.Parse(Console.ReadLine());
    if (grade < 4.00)
    {
        Console.WriteLine($"{name} has been excluded at {count} grade");
        return;
    }

    sum += grade;
    count++;
}

avr = sum / (count - 1);
Console.WriteLine($"{name} graduated. Average grade: {avr:f2}");