Console.WriteLine("калькулятор чаевых");
Console.Write("введите сумму счета (руб): ");
double bill = Convert.ToDouble(Console.ReadLine());
Console.Write("введите процент чаевых: ");
double tipPercent = Convert.ToDouble(Console.ReadLine());
double tipAmount = bill * (tipPercent / 100);
double totalAmount = bill + tipAmount;

Console.WriteLine("результат: ");
Console.WriteLine($"сумма счета: {bill} руб");
Console.WriteLine($"чаевые: ({tipPercent}%): {tipAmount} руб");
Console.WriteLine($"итого к оплате: {totalAmount} руб");
Console.WriteLine("Спасибо!");