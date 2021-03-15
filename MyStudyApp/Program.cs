using System;

class MainClass
{
  

    public static void Main(string[] args)
    {
       
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } ,{ 8,9,10},{ 11,12,13} };

        Console.WriteLine("Количество строк: {0} ",array.GetUpperBound(0) + 1 );
        Console.WriteLine("Количество столбцов: {0} ", array.GetUpperBound(1) + 1);

        for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
        {
            for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
                Console.Write(array[j, i] + " ");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
