// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Диапазон любой, ввод зависит от пользователя. (размер, значения)
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
    for (int i=0; i< array.Length; i++)
{
    Console.Write("Введите {0}-е число: ", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int Poisk(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i % 2 == 1)
       sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine("Сумма элементов чисел на нечетных похзициях: " + Poisk(array));
