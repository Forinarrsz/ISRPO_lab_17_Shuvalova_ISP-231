
Console.WriteLine("введите N ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int max = array[0];
for (int i = 0; i < n; i++)
{
    array[i] = i + 1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{i}: {array[i]}");
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);