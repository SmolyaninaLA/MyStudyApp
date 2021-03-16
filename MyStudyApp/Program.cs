using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

        var ( name,  age) = ("Евгения",27);
        Console.WriteLine("Имя {0}", name);
        Console.WriteLine("Возраст {0}",age);

        Console.WriteLine("Ведите имя :");
        name = Console.ReadLine();

        Console.WriteLine("Введитн возраст цифрами :");
        age = Convert.ToInt32( Console.ReadLine());


        Console.WriteLine("Ваше имя {0}",name);
        Console.WriteLine("Ваш возраст {0}",age);



        Console.ReadKey();
    }
}
