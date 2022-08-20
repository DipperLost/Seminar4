Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
numberB = Math.Abs(numberB);
int result = numberA;
for(int count = 0; numberB > 1; count++)
{
    result = result * numberA;
    numberB = numberB - 1;
}
Console.WriteLine(result);
