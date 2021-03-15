using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

       int[,] array = { {-5, 6,9,1,2,-3 },{ -8,8,1,1,2,-3} };
        int countP = 0;
// через for
        for(int i = 0; i < array.GetUpperBound(0) + 1 ; i++)
        {
            for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
            {
                if (array[i, j] > 0)
                {
                    countP++;
                }
            }
                  
         }

        int countPlus = 0;
// через foreach
        foreach(var arr in  array)
        {
            if (arr > 0)
                countPlus++;

        }


        Console.WriteLine("Количество положительных чисел : {0} {1}",countP,countPlus);

        Console.ReadKey();
    }
}
