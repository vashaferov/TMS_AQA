// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array1;
int n = 4;
array1 = new int[n];

int[] array = { 1, 9, 3, 6, 5 };

Console.WriteLine("\narray:");
for (int i = 0; i < array.GetLength(0); i++)
    Console.Write(array[i] + " ");

Console.WriteLine("\n\n---------------------");
Console.WriteLine("|Length: " + array.Length + "          |");             // количество всех элементов
Console.WriteLine("|Rank: " + array.Rank + "            |");               // ранк массива
Console.WriteLine("|GetLength(0): " + array.GetLength(0) + "    |");       // количество строк
Console.WriteLine("|GetUpperBound(0): " + array.GetUpperBound(0) + "|");   // Верхний индекс строк
Console.WriteLine("|GetLowerBound(0): " + array.GetLowerBound(0) + "|");   // Нижний индекс строк
Console.WriteLine("---------------------");

Console.WriteLine("\nold array[2]: " + array[2]);
array[2] = 10;
Console.WriteLine("new array[2]: " + array[2]);

Console.WriteLine("\nnew array:");
foreach (int j in array)
    Console.Write(j + " ");

Console.WriteLine("\n\nrandom array:");
for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = new Random().Next(100);
    Console.Write(array[i] + " ");
}

Console.WriteLine("\n\ndo while:");
int u = 6;
bool flag = true;
do
{
    if (u <= 0)
        flag = false;
    Console.Write(u-- + " ");
}
while (flag);


int[,] array2d = new int[4, 5];

for (int k = 0; k < array2d.GetLength(0); k++)
    for (int m = 0; m < array2d.GetLength(1); m++)
        array2d[k, m] = k + m;

int rows = array2d.GetLength(0);
int cols = array2d.Length / rows;

Console.WriteLine("\n\n2d array:");
for (int i1 = 0; i1 < rows; i1++)
{
    for (int j1 = 0; j1 < cols; j1++)
        Console.Write(array2d[i1, j1] + "\t");
    Console.WriteLine();
}
 
Console.WriteLine("\n\n---------------------");
Console.WriteLine("|Length: " + array2d.Length + "         |");
Console.WriteLine("|Rank: " + array2d.Rank + "            |");
Console.WriteLine("|GetLength(0): " + array2d.GetLength(0) + "    |");
Console.WriteLine("|GetLength(1): " + array2d.GetLength(1) + "    |");
Console.WriteLine("|GetUpperBound(0): " + array2d.GetUpperBound(0) + "|");
Console.WriteLine("|GetUpperBound(1): " + array2d.GetUpperBound(1) + "|");
Console.WriteLine("|GetLowerBound(0): " + array2d.GetLowerBound(0) + "|");
Console.WriteLine("|GetLowerBound(1): " + array2d.GetLowerBound(1) + "|");
Console.WriteLine("---------------------");

// -============================================= Трехмерный массив =============================================-

int[,,] array3D = new int[,,]
{
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    },
    {
        { 7, 8, 9 },
        { 10, 11, 12 }
    }
};

Console.WriteLine("\n\n3d array:");

for (int i = 0; i <= array3D.GetUpperBound(0); i++)
{
    Console.WriteLine($"-========= Level {i} ==========-");
    for (int j = 0; j <= array3D.GetUpperBound(1); j++)
    {
        for (int k = 0; k <= array3D.GetUpperBound(2); k++)
        {
            Console.Write($"{array3D[i, j, k]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"-============================-");
}

Console.WriteLine("\nLength: " + array3D.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array3D.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array3D.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array3D.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array3D.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array3D.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLength(2): " + array3D.GetLength(2));           // количество столбцов
Console.WriteLine("GetUpperBound(2): " + array3D.GetUpperBound(2));   // Верхний индекс столбцов

Console.WriteLine("GetLowerBound(0): " + array3D.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array3D.GetLowerBound(1));   // Нижний индекс столбцов
Console.WriteLine("GetLowerBound(2): " + array3D.GetLowerBound(2));   // Нижний индекс столбцов


int[][] numbers =
{
    new int[] { 1, 2 },
    new int[] { 1, 2, 3, 4, 5 },
    new int[] { 1, 2, 3 }
};

foreach (int[] row in numbers)
{
    for (int i = 0; i < row.Length; i++)
    {
        row[i] = new Random().Next(100);
    }
}

Console.WriteLine("\nЗубчатый массив:");
for (int i = 0; i <= numbers.GetUpperBound(0); i++)
{
    for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }

    Console.WriteLine();
}

Console.WriteLine("\n\nЗАДАЧА");

int[] nums = { -4, 8, 10, 2, 12, 0, 5};

foreach (int nn in nums)
    Console.Write(nn + " ");

for (int i = 0;i <= nums.Length / 2; i++)
{
    int temp = nums[i];
    nums[i] = nums[nums.Length - 1 - i];
    nums[nums.Length - 1 - i] = temp;
}
Console.WriteLine();
foreach (int nn in nums)
    Console.Write(nn + " ");
