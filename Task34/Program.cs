//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Диапазон трехзначных чисел, ввод случайный.


Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int[] array = new int[n]; 
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100,1000);
}
int Poisk(int[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Количество четных чисел в массиве: " + Poisk(array));
