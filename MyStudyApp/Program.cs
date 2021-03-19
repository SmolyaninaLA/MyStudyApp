using System;

class MainClass
{

    static string ShowColor( string username, int userage)
    {
        Console.WriteLine("{0} , {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username,userage);
        var color = Console.ReadLine();
        
        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }

    static void ShowColors(string username , params string[] favcolors)
    {
        Console.WriteLine("{0} , ваши любимые цвета :",username);
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }

    }

    static int[] GetArrayFromConsole( int num = 5 )
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    private static int[] SortArray(int[] num)
    {
        int per;

        for (int i = 0; i < num.Length - 1; i++)
        {
            for (int j = i + 1; j < num.Length; j++)
            {
                if (num[i] > num[j])
                {
                    per = num[j];
                    num[j] = num[i];
                    num[i] = per;
                }


            }
        }

        return num;
    }

    static void ShwArray(bool sort = false, params int[] nums )
    {
       var  arraysort = nums;
        if (sort)
        {
            arraysort = SortArray(nums);
         
        }
       for (int i = 0; i < arraysort.Length; i++)
            {
                Console.Write(arraysort[i] + " ");
            }


      
    }

    public static void Main(string[] args)
    {
        /*
          (string name, int age) anketa;


          Console.Write("Введите имя: ");
          anketa.name = Console.ReadLine();
          Console.Write("Введите возрас с цифрами:");
          anketa.age = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Ваше имя: {0}", anketa.name);
          Console.WriteLine("Ваш возраст: {0}", anketa.age);

          var favcolors = new string[3];

          for (int i = 0; i < favcolors.Length; i++ )
          {
              favcolors[i] = ShowColor(anketa.name,anketa.age);
          }

         ShowColors(anketa.name,favcolors);

          Console.ReadKey();
    */

        var array = GetArrayFromConsole(6);

        ShwArray(true, array);
       
       
    }
}