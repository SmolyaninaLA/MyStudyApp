using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string myName;
        myName = "Jane";
        var age = 27;
        string favcolor = "black";

        Console.WriteLine(myName);
        Console.WriteLine("\t Привет, \n мир");
        Console.WriteLine("\t Мне 27 лет");
        Console.WriteLine("\t Меня зовут \n  Jane");

        Console.WriteLine("\u0040");
        Console.WriteLine("\u0023");

        Console.WriteLine(52);

        DayOfWeek myFavoriteDay;
        myFavoriteDay = DayOfWeek.Sunday;

        Console.WriteLine("Мой любимфй день недели " + myFavoriteDay);

        Console.WriteLine("{0} \n  {1} \n {2}", myName,age,favcolor);

        
        double result = 5.0 / 2.0 * 3.0;
        Console.WriteLine("Value: {0}", result);

        int k = -10;
        int b = 20;
        b = b - (-k);
        Console.WriteLine("Value: {0}", b);

       result = 10 % 3;
        Console.WriteLine("Value: {0}", result);

        Console.Write("Enter yuor name: ");
        string name = Console.ReadLine();


        Console.Write("Enter yuor age: ");
        byte age1 = checked((byte) int.Parse(Console.ReadLine()));


        Console.Write("What your favorite day of  week? ");
        var Day = (DaysOfWeek)int.Parse(Console.ReadLine());

       

        Console.WriteLine(" Your name is {0} and age is {1}", name, age1);

        Console.WriteLine(" Your favorite day is {0}",Day );

               
        Console.ReadKey();
    }

    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Semafore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
     
    }

 

}
