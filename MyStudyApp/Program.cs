using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

        (string Name, string Type, double age, int NameCount) Pet;


        Console.WriteLine("Ведите имя питомца :");
        Pet.Name = Console.ReadLine();

        Console.WriteLine("Введитr тип питомца :");
        Pet.Type = Console.ReadLine();

        Console.WriteLine("Введитr возраст питомца :");
       Pet.age = Convert.ToDouble( Console.ReadLine());


        Console.WriteLine(" У вас есть {0} по имени {1}  {2}-ти лет",Pet.Type,Pet.Name,Pet.age);

        Pet.NameCount = Pet.Name.Length;

        Console.WriteLine(" длина имени {0} символов",Pet.NameCount );




        Console.ReadKey();
    }
}
