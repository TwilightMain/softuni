int age = int.Parse(Console.ReadLine());
double priceWashing = double.Parse(Console.ReadLine());
int price = int.Parse(Console.ReadLine());
int brotherMoney = 0;
double money = 0;
double currentGift = 10;
int toys = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        money += currentGift;
        currentGift += 10;    
        brotherMoney++;
    }
    else
    {
        toys++;
    }
}

int sumFromToys = toys * price;
double sumFinal = (money + sumFromToys) - brotherMoney;

if (sumFinal >= priceWashing)
{
    double change = sumFinal - priceWashing;
    Console.WriteLine($"Yes! {change:f2}");
}
else if (sumFinal < priceWashing)
{
    double needMoney = Math.Abs(sumFinal - priceWashing);
    Console.WriteLine($"No! {needMoney:f2}");
}