// Метод для ввода данных
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}
// Метод принимающих на вход массив строк и возвращающий массив лишь с теми строками, которые по длине меньше либо равны n.
string[] SortArrLess(string str, int n)
{
    string[] arr = str.Split(" ");
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n)
        {
            arr[j] = arr[i];
            j++;
        }
    }
    Array.Resize(ref arr, j);
    return arr;
}
// Метод для печати массива в консоль
void PrintArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

PrintArr(SortArrLess(ReadData("Введите элементы массива через пробел (hello 2 -2):"), 3));

// string[] SortArrLess(string str, int n)
// {   // Поиск количества элементов, длина которых <=n
//     string[] inArr = str.Split(" ");
//     int j = 0;
//     for (int i = 0; i < inArr.Length; i++)
//     {
//         if (inArr[i].Length <= n) j++;
//     }
//     // Заполнение массива элементами <=n
//     string[] outArr = new string[j];
//     int k = 0;
//     for (int i = 0; i < inArr.Length; i++)
//     {
//         if (inArr[i].Length <= n)
//         {
//             outArr[k] = inArr[i];
//             k++;
//         }
//     }
//     return outArr;
// }