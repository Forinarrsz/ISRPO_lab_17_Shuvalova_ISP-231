Console.WriteLine("подъем по лестнице");

Console.Write("введите нужный этаж: ");
int targetfloor = Convert.ToInt32(Console.ReadLine());
int currentfloor = 1;

Console.WriteLine("подъем начат");
while (currentfloor < targetfloor)
{
    currentfloor++;
    Console.WriteLine($"поднялись на {currentfloor}-й этаж");
}
Console.WriteLine($"вы достигли {targetfloor} этажа");