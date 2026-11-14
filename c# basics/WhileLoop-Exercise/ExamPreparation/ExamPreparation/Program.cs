int failThreshold = int.Parse(Console.ReadLine());
int badGrades = 0;
int solvedExercises = 0;
double gradeSum = 0;
string lastExercise = "";
bool isFailed = true;

while (badGrades < failThreshold)
{
    string problemName = Console.ReadLine();
    if (problemName == "Enough")
    {
        isFailed = false;
        break;
    }
    int grade = int.Parse(Console.ReadLine());
    if (grade <= 4)
    {
        badGrades++;
    }
    gradeSum += grade;
    solvedExercises++;
    lastExercise = problemName;
}

if (isFailed)
{
    Console.WriteLine($"You need a break, {failThreshold} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {gradeSum /solvedExercises:f2}");
    Console.WriteLine($"Number of problems: {solvedExercises}");
    Console.WriteLine($"Last problem: {lastExercise}");
}