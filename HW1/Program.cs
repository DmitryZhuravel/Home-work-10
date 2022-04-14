/* Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1*/
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = new int[info.Length];
int n = 0;
for (int i = 0; i < info.Length; i++)
{
    String line = "";
    for (int k = n; k < n + info[i]; k++)
    {
        line += Convert.ToString(data[k]);
    }
    Console.Write(Convert.ToString(Convert.ToInt32(line, 2), 10));
    Console.Write(" ");
    n += info[i];
}
