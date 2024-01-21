using System.Diagnostics.Contracts;

namespace Delegate;

public class Sorts
{
    public delegate int[] SortArray(int[] array);

    public void Run()
    {
        Random r = new Random();
        SortArray sortArray;
        
        Console.Write("Введите размер массива: ");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[length];
        int[] array2 = new int[length];

        Console.WriteLine("Массив:");
        for(int i = 0; i <= length - 1; i++)
        {
            array1[i] = r.Next(100);
            array2[i] = array1[i];
            Console.Write(array1[i] + " ");
        }
        Console.WriteLine();
        
        sortArray = DoSorting(VariantsSort.BubbleSort);
        sortArray(array1);

        Console.WriteLine($"Сортировка пузырьком:");
        foreach(var item in array1)
            Console.Write(item + " ");   
        Console.WriteLine();

        sortArray = DoSorting(VariantsSort.InsertionSort);
        sortArray(array2);

        Console.WriteLine($"Сортировка вставками:");
        foreach(var item in array2)
            Console.Write(item + " ");
        Console.WriteLine();      
    }

    private int[] BubbleSort(int[] array)
    {

        for (var i = 1; i < array.Length; i++)
        {
            for (var j = 0; j < array.Length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    var temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }

        return array;
    }
    private int[] InsertionSort(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var key = array[i];
            var j = i;
            while ((j > 0) && (array[j - 1] > key))
            {
                var temp = array[j-1];
                array[j-1] = array[j];
                array[j] = temp;

                j--;
            }

            array[j] = key;
        }

        return array;
    }

    SortArray DoSorting(VariantsSort vs)
    {
        switch(vs)
        {
            case VariantsSort.BubbleSort: return BubbleSort;
            case VariantsSort.InsertionSort: return InsertionSort;
            default: return null;           
        }
    }

    enum VariantsSort
    {
        BubbleSort, 
        InsertionSort
    }
}
