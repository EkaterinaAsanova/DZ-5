//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 69.4 -22 0.4 78] ->56
// Диапазон любой, ввод зависит от пользователя. (размер, значения)

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];
    for (int i=0; i< array.Length; i++)
{
    Console.Write("Введите {0}-е число: ", i + 1);
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Разница максимального и минимального значения в массиве равна: " + (Max(array) - Min(array)));
double Max(double[] array)
{
    double znMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > znMax)
            znMax = array[i];
    }
    return znMax; 
}
double Min(double[] array)
{
    double znMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < znMin)
            znMin = array[i];
    }
    return znMin; 
}
