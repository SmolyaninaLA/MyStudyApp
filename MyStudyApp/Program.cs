using System;

class MainClass
{
  

    public static void Main(string[] args)
    {
       
        int[] array = { 5,6,9,1,2,3,4 };
        int   eMax;
        int SumEl = 0;

        Console.Write("Исходный массив:  ");

        for (int i = 0; i < array.Length; i++)
        {
         
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Сортировка методом пузырька: ");
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i -1; j++  )  

             if (array[j] > array[j+1] )
                {
                    eMax = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = eMax;
                }
           
        }

            

        for (int i = 0; i < array.Length; i++)
        {
            SumEl = SumEl + array[i];
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма элементов = {0}",SumEl);    

            Console.ReadKey();
    }
}
