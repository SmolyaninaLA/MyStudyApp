using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

       int[,] array = { {-5, 6,9,1,2,-3 },{ -8,8,1,1,2,-3} };
        int per;

        for(int i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < array.GetUpperBound(1) ; j++)
            
                for (int k = j + 1; k < array.GetUpperBound(1) + 1; k++)
                {
                    if (array[i,j] > array[i,k]) 
                    {
                        per = array[i,k];
                        array[i,k] = array[i,j];
                        array[i,j] = per;
                    }

                }

            
             
                  
         }

        for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
        {
            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                Console.Write(array[k,i] + " ");
            }
            Console.WriteLine();
        } 

            

        Console.ReadKey();
    }
}
