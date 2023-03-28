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