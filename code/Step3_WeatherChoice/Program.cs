// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую температуру ");
int temp = Convert.ToInt32(Console.ReadLine());

if (temp >=20) { Console.WriteLine("наденьте легкую одежду"); }
else {
     Console.WriteLine("наденьте теплую одежду");
}

Console.WriteLine("Хорошего дня");
