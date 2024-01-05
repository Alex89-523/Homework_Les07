//  Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] Array2(int[] array, int i)
{
    int length = array.Length;
    if(i < (length/2))
    {
        int temp = array [i];
        array[i] = array[(length - 1) - i];
        array[(length - 1) - i] = temp;
        i++;
        Array2(array, i);
    }
    return array;
}

int[] RandomArray(int[] array, int i)
{
    array[i] = new Random().Next(1, 100);
    if(i < array.Length - 1)
    {
        i++;
        RandomArray(array, i);
    }
    return array;
}


System.Console.Write("Длинна массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int[] Array1 = new int[size];

Array1 = RandomArray(Array1, 0);
System.Console.WriteLine($"[{String.Join(" ", Array1)}]");
System.Console.WriteLine(String.Join(" ", Array2(Array1,0)));