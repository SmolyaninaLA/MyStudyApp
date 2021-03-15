using System;

class MainClass
{
    private const string V = " ";

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите свое имя");

        var Name = Console.ReadLine().ToString();
        string NewName = "";
   
        
      
        for (int i = Name.Length - 1 ; i >= 0 ; i--)
        {
            NewName  = NewName + Name[i] + " ";
                      
        }
        Console.WriteLine("Ваше имя по букваи:");
        Console.WriteLine("{0} Последняя буква вашего имени : {1}", NewName, Name[Name.Length - 1]);
        Console.WriteLine("Первая буква имени :{0}",Name[0] );
        Console.ReadKey();
    }
}
