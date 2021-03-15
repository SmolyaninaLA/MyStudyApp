using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

        var array = new int[] { 1, 6, 0, 4, 12, -8, -45, 10 };
        int countP = 0;

        for(int i = 0; i < array.Length ; i++)

            {
            if(array[i] > 0 )
            {
                countP++;
            }
              
            }

        Console.WriteLine("Количество положительных чисел : {0}",countP);

        Console.ReadKey();
    }
}
