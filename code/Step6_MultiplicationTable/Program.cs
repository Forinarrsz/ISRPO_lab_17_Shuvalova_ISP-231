// See https://aka.ms/new-console-template for more information
Console.WriteLine("Таблица умножения");
Console.Write("enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"таблица умножения для {number}: ");

for (int i = 1; i <=10; i++) {
    int result = number * i;
    Console.WriteLine($"{number} * {i} = {result}");
}
Console.WriteLine("The end");