using System;

class MainClass
{
    public static void Main(string[] args)
    {
                    
        Console.Write("Enter yuor name: ");
        var name = Console.ReadLine();


        Console.Write("Enter yuor age: ");
        var age = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Your name is {0} and age is {1}", name, age);

        Console.Write("Enter your birthday: ");
        var birthday = Console.ReadLine();

        Console.WriteLine("Your birthday is {0}", birthday);

               
        Console.ReadKey();
    }

 
 

}
