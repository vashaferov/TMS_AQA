// See https://aka.ms/new-console-template for more information
//int[] array = new int[4];
//int value = array[5];
try
{
    Object obj = null;
    obj.GetHashCode();
} catch (NullReferenceException) 
{
    Console.WriteLine("Ошибка!");
}
