using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

        (string name, int age) anketa;

        Console.WriteLine("Ведите имя :");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Введитн возраст цифрами :");
        anketa.age = Convert.ToInt32( Console.ReadLine());


        Console.WriteLine("Ваше имя {0}",anketa.name);
        Console.WriteLine("Ваш возраст {0}",anketa.age);



        Console.ReadKey();
    }
}
