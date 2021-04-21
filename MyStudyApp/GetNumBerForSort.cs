using System;
using System.Collections.Generic;
using System.Text;



class GetNumBerForSort
{
   
    public static int GetNumberSort()
    {
        int parsort = 0;
        bool res = false;
        Console.WriteLine();
        Console.WriteLine("Введите параметры сортировки 1 - по возрастанию, 2 - по убыванию.");

        while (!res || parsort < 1 || parsort > 2)
        {
            try
            {

                res = int.TryParse(Console.ReadLine(), out parsort);
                if (!res)
                {
                    throw new MyException("Введено не число");
                }
                else
                {
                    if (parsort < 1 || parsort > 2)
                    {
                        throw new MyException("Введеное число не 1 или 2");
                    }
                }
            }

            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       return parsort;
    }

   
}


