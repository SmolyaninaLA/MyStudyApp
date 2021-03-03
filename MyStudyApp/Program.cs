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

        Console.WriteLine("{0} \n {1} \n {2}", myName, age, favcolor);

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
