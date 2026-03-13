Console.WriteLine("введите N ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = i + 1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{i}: {array[i]}");
}