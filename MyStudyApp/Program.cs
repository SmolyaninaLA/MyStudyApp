﻿using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

        int[][] array = new int[3][];

        array[0] = new int[2] { 1, 2 };
        array[1] = new int[3] { 1, 2,3 };
        array[2] = new int[5] { 1, 2,3 ,4,5};

        foreach (var row in array)
        {
            foreach (var column in row)
            {
                Console.Write(column + " ");
            }
           
        }
        Console.ReadKey();
    }
}
