// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
for (int index = 0; index < num; index++)
{
    array[index] = Math.Pow(index + 1, 3);
    Console.Write($"{array[index]} ");
}