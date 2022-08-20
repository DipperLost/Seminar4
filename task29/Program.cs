Console.WriteLine("Введите колличество элементов массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
Random rnd = new Random();
for (int count = 0; count < i;)
{
    array[count] = Convert.ToInt32(rnd.Next(0, 10));
    count++;
}
for (int count = 0; count < i - 1;)
{
    Console.Write(array[count] + ",");
    count++;
}
Console.WriteLine(array[i - 1]);
