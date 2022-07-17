Console.WriteLine("Введите количество проверяемых чисел:");
int numbers = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < numbers; i++)
{
    int digit = Convert.ToInt32(Console.ReadLine());
    if (digit > 0)
    count++;
}

Console.Write("Positives {0}", count);
Console.WriteLine();
