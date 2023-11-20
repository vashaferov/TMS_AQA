// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

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

Console.WriteLine("\n\n2Darray:");
int[,] array2d = new int[4, 5];

for (int k = 0; k < array2d.GetLength(0); k++)
    for (int m = 0; m < array2d.GetLength(1); m++)
        array2d[k, m] = k + m;

int rows = array2d.GetLength(0);
int cols = array2d.Length / rows;
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
Console.WriteLine("---------------------");*/

int[] array1, array2;
int[,] array2d;
int sizeArray;
bool mainFlag = true;

while (mainFlag)
{
    Console.Write("----------\nВведите номер задания (от 1 до 12): ");
    string numTask = Console.ReadLine();
    Console.Clear();

    switch (numTask)
    {
        case "1":
            {
                Console.WriteLine("ЗАДАНИЕ 1");

                array1 = new int[10];
                bool flag = false;

                Console.Write("Введите число: ");
                int checkNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    array1[i] = new Random().Next(10);
                    if (array1[i] == checkNum)
                    {
                        flag = true;
                        Console.Write("|" + array1[i] + "| ");
                    }
                    else
                        Console.Write(array1[i] + " ");
                }
                Console.WriteLine("\n");

                if (flag)
                    Console.WriteLine("Найдено совпадение!");
                else
                    Console.WriteLine("Совпадений нет.");

                break;
            }
        case "2":
            {
                Console.WriteLine("ЗАДАНИЕ 2");

                int j = 0;
                array1 = new int[10];
                int counterHit = 0;

                Console.Write("Введите число: ");
                int checkNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    array1[i] = new Random().Next(10);
                    Console.Write(array1[i] + " ");
                    if (array1[i] == checkNum)
                        counterHit++;
                }
                Console.WriteLine("\n");

                if (counterHit != 0)
                {
                    array2 = new int[array1.Length - counterHit];

                    Console.WriteLine("Найдено совпадение! Новый массив: ");
                    for (int i = 0; i < array1.GetLength(0); i++)
                    {
                        if (array1[i] != checkNum)
                        {
                            array2[j] = array1[i];
                            Console.Write(array2[j] + " ");
                            j++;
                        }
                    }
                    Console.WriteLine($"\nСовпало {counterHit} раз.");
                }
                else
                    Console.WriteLine("Совпадений нет.");
                break;
            }
        case "3":
            {
                Console.WriteLine("ЗАДАНИЕ 3");

                int minNum, maxNum, meanNum = 0;

                Console.Write("Введите размер массива: ");
                sizeArray = Convert.ToInt32(Console.ReadLine());
                array1 = new int[sizeArray];

                Console.Write("\nМассив: ");
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    array1[i] = new Random().Next(sizeArray); // для разнообразия содержимого массивов
                    Console.Write(array1[i] + " ");
                }

                minNum = array1[0];
                maxNum = array1[0];

                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    if (minNum > array1[i])
                        minNum = array1[i];
                    if (maxNum < array1[i])
                        maxNum = array1[i];
                    meanNum += array1[i];
                }

                Console.WriteLine("\nМинимальное значение: " + minNum);
                Console.WriteLine("Максимальное значение: " + maxNum);
                Console.WriteLine("Среднее значение: " + meanNum / sizeArray);

                break;
            }
        case "4":
            {
                Console.WriteLine("ЗАДАНИЕ 4");

                array1 = new int[5];
                array2 = new int[5];
                int meanNum1 = 0, meanNum2 = 0;

                Console.Write("Массив первый: ");
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    array1[i] = new Random().Next(10);
                    Console.Write(array1[i] + " ");
                    meanNum1 += array1[i];
                }

                Console.Write("\nМассив второй: ");
                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    array2[i] = new Random().Next(10);
                    Console.Write(array2[i] + " ");
                    meanNum2 += array2[i];
                }

                if (meanNum1 == meanNum2)
                    Console.WriteLine($"\nСредние арифметические равны: {meanNum1} = {meanNum2}");
                else if (meanNum1 > meanNum2)
                    Console.WriteLine($"\nСреднее арифметическое первого массива больше чем у второго: {meanNum1} > {meanNum2}");
                else Console.WriteLine($"\nСреднее арифметическое первого массива меньше чем у второго: {meanNum1} < {meanNum2}");

                break;
            }
        case "5":
            {
                Console.WriteLine("ЗАДАНИЕ 5");

                bool flagSizeArray = false;
                int countEven = 0;
                int j = 0;

                do
                {
                    Console.Write("Введите размер массива (5 < *размер массива* <= 10): ");
                    sizeArray = Convert.ToInt32(Console.ReadLine());

                    if (sizeArray <= 5 || sizeArray > 10)
                        Console.WriteLine("\nОшибка. Размер массива выходит за доступные значения");
                    else
                        flagSizeArray = true;

                } while (!flagSizeArray);

                array1 = new int[sizeArray];

                Console.WriteLine("Первый массив: ");
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    array1[i] = new Random().Next(10);
                    Console.Write(array1[i] + " ");

                    if (array1[i] % 2 == 0)
                        countEven++;
                }

                if (countEven > 0)
                {
                    Console.WriteLine("\nВ массиве четных элементов: " + countEven + "\nВторой массив: ");

                    array2 = new int[countEven];

                    for (int i = 0; i < array1.GetLength(0); i++)
                    {
                        if (array1[i] % 2 == 0)
                        {
                            array2[j] = array1[i];
                            Console.Write(array2[j] + " ");
                            j++;
                        }
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("\nВ массиве нет четных элементов");
                }

                break;
            }
        case "6":
            {
                Console.WriteLine("ЗАДАНИЕ 6");

                array1 = new int[new Random().Next(10)];

                Console.WriteLine("Массив:");
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    array1[i] = new Random().Next(10);
                    Console.Write(array1[i] + " ");
                }

                Console.WriteLine("\nМассив после изменения:");
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    if (i % 2 == 0)
                        Console.Write(array1[i] + " ");
                    else
                    {
                        array1[i] = 0;
                        Console.Write(array1[i] + " ");
                    }
                }
                Console.WriteLine();

                break;
            }
        case "7":
            {
                Console.WriteLine("ЗАДАНИЕ 7");

                string[] nameArray = { "Max", "Checo", "Lando", "Alonso", "Charles" };

                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < nameArray.GetLength(0); i++)
                    Console.Write(nameArray[i] + " ");

                Array.Sort(nameArray);

                Console.WriteLine("\nМассив после сортировки:");
                for (int i = 0; i < nameArray.GetLength(0); i++)
                    Console.Write(nameArray[i] + " ");
                Console.WriteLine("");

                break;
            }
        case "8":
            {
                Console.WriteLine("ЗАДАНИЕ 8");

                array1 = new int[] { 9, 7, 4, 8, 6, 3, 0, 2, 1, 5 };
                int temp;

                Console.WriteLine("Массив:");
                for (int i = 0; i < array1.GetLength(0); i++)
                    Console.Write(array1[i] + " ");

                for (int i = 0; i < array1.Length; i++)
                    for (int j = 0; j < array1.Length - 1 - i; j++)
                        if (array1[j] > array1[j + 1])
                        {
                            temp = array1[j];
                            array1[j] = array1[j + 1];
                            array1[j + 1] = temp;
                        }

                Console.WriteLine("\nМассив после пузырьковой сортировки:");
                for (int i = 0; i < array1.GetLength(0); i++)
                    Console.Write(array1[i] + " ");

                Console.WriteLine("");
                break;
            }
        case "9":
            {
                Console.WriteLine("ЗАДАНИЕ 9");

                int[,,] firstArray3d = new int[3, 4, 1] {
                    { {1}, {0}, {0}, {0} },
                    { {0}, {1}, {0}, {0} },
                    { {0}, {0}, {0}, {0} }
                };
                int[,,] secondArray3d = new int[4, 3, 1] {
                    { {1}, {2}, {3} }, 
                    { {1}, {1}, {1} },
                    { {0}, {0}, {0} }, 
                    { {2}, {1}, {0} }
                };

                Console.WriteLine("Первый массив:");
                for (int k = 0; k < firstArray3d.GetLength(0); k++)
                {
                    for (int m = 0; m < firstArray3d.GetLength(1); m++)
                    {
                        Console.Write(firstArray3d[k, m, 0] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Второй массив:");
                for (int k = 0; k < secondArray3d.GetLength(0); k++)
                {
                    for (int m = 0; m < secondArray3d.GetLength(1); m++)
                    {
                        Console.Write(secondArray3d[k, m, 0] + " ");
                    }
                    Console.WriteLine();
                }

                int[,,] result = new int[firstArray3d.GetLength(0), secondArray3d.GetLength(1), secondArray3d.GetLength(2)];
                
                for (int i = 0; i < firstArray3d.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray3d.GetLength(1); j++)
                    {
                        for (int l = 0; l < secondArray3d.GetLength(2); l++)
                        {
                            int sum = 0;
                            for (int x = 0; x < firstArray3d.GetLength(1); x++)
                            {
                                sum += firstArray3d[i, x, l] * secondArray3d[x, j, l];
                            }
                            result[i, j, l] = sum;
                        }
                    }
                }

                Console.Write("Результат умножения двух массивов: ");
                foreach (int i in result)
                    Console.Write(i + " ");

                Console.WriteLine();
                break;
            }
        case "10":
            {
                Console.WriteLine("ЗАДАНИЕ 10");

                array2d = new int[2, 8];
                int summ = 0;

                Console.WriteLine("Двумерный массив:");
                for (int k = 0; k < array2d.GetLength(0); k++)
                {
                    for (int m = 0; m < array2d.GetLength(1); m++)
                    {
                        array2d[k, m] = new Random().Next(10);
                        summ += array2d[k, m];
                        Console.Write(array2d[k, m] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Сумма всех элементов массива: " + summ);


                break;
            }
        case "11":
            {
                Console.WriteLine("ЗАДАНИЕ 11");

                array2d = new int[6, 6];
                string firstDiagonal = "Первая диагональ: ";
                string secondDiagonal = "Вторая диагональ: ";

                Console.WriteLine("Двумерный массив:");
                for (int k = 0; k < array2d.GetLength(0); k++)
                {
                    for (int m = 0; m < array2d.GetLength(1); m++)
                    {
                        array2d[k, m] = new Random().Next(10);
                        Console.Write(array2d[k, m] + " ");

                        if (k == m)
                            firstDiagonal += array2d[k, m] + " ";
                        if (k + m == 5)
                            secondDiagonal += array2d[k, m] + " ";
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(firstDiagonal + "\n" + secondDiagonal);

                break;
            }
        case "12":
            {
                Console.WriteLine("ЗАДАНИЕ 12");

                array2d = new int[6, 6];
                int temp = 0;

                Console.WriteLine("Двумерный массив до сортировки:");
                for (int k = 0; k < array2d.GetLength(0); k++)
                {
                    for (int m = 0; m < array2d.GetLength(1); m++)
                    {
                        array2d[k, m] = new Random().Next(10);
                        Console.Write(array2d[k, m] + " ");
                    }
                    Console.WriteLine();
                }

                for (int k = 0; k < array2d.GetLength(0); k++)
                {
                    for (int m = 0; m < array2d.GetLength(1); m++)
                        for (int j = 0; j < array2d.GetLength(1) - 1 - m; j++)
                            if (array2d[k, j] > array2d[k, j + 1])
                            {
                                temp = array2d[k, j];
                                array2d[k, j] = array2d[k, j + 1];
                                array2d[k, j + 1] = temp;
                            }
                }

                Console.WriteLine("Двумерный массив после сортировки:");
                for (int k = 0; k < array2d.GetLength(0); k++)
                {
                    for (int m = 0; m < array2d.GetLength(1); m++)
                        Console.Write(array2d[k, m] + " ");
                    Console.WriteLine();
                }
                    
                break;
            }
        default:
            {
                Console.WriteLine("Неверный номер задания.");
                break;
            }
    }
}