using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var anketa = GetAnketa();

        ShowAnketa(anketa);

       
        Console.ReadKey();
    }
    //проверка корректности
    static bool CheckCorrect( string param, out int intParam )
    {
    
        if (int.TryParse(param, out int par))
        {
            if (par <= 0)
            {
                intParam = par;
                return false;
            }
            else
            {
                intParam = par;
                return true;
            }
                
        }
        else
        {
            intParam = 0;
            return  false;
        }
    }

   //клички питомцев
    static string[] GetPetsName(int CountPets )
    {
        var mas = new string[CountPets];
        if (CountPets > 0)
        {
            Console.WriteLine("Введите клички {0} питомцкв", CountPets);

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Console.ReadLine();
            }
        }
        
        return mas;
    }
    //отображение не консили кличек
    static void ShowPets(string username, params string[] pets)
    {
        if (pets.Length > 0)
        {
            Console.WriteLine("{0} , ваши домашние животные :", username);
            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }
        }
     

    }
    //массив любимых красок

    static string[] GetFavoritColors (int CountColors)
    {
        var mas = new string[CountColors ];
        if (CountColors > 0)
        {
            Console.WriteLine("Введите {0} предпочтительных цветов ", CountColors);

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Console.ReadLine();
            }
        }
         return mas;
    }
        

    static void ShowColors(string username , params string[] favcolors)
    {
        if (favcolors.Length > 0)
        {
            Console.WriteLine("{0} , ваши любимые цвета :", username);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
       

    }

    
    static (string name, string lastName, int age , bool hasPets, int countPets, int CountColors, string[] PetsName, string[] favoritColors) GetAnketa()
    {
       (string name, string lastName, int age, bool hasPets, int countPets, int CountColors, string[] PetsName, string[] favoritColors) anketa;
        int intPar;
        string strPar;

       Console.Write("Введите имя: ");
       anketa.name = Console.ReadLine();

        Console.Write("Введите фамилию: ");
       anketa.lastName = Console.ReadLine();

        Console.Write("Введите возраст (полных лет) цифрами :");

        strPar = Console.ReadLine();
        while (!CheckCorrect(strPar, out intPar))
        {
            Console.Write("Возраст введен некорртно, повторите ввод еще раз :");
            strPar = Console.ReadLine();
        }

        anketa.age = intPar;

        Console.Write("{0}, у вас есть питомец 'да или 'нет' ? ", anketa.name);
        string res = (Console.ReadLine()).ToUpper();

        anketa.hasPets = false;
        if (res == "ДА")
        {
            anketa.hasPets = true;
        }
        anketa.countPets = 0;
       
        if (anketa.hasPets)
        {
            Console.Write("{0}, сколько животных у вас живет? ", anketa.name);
            strPar = Console.ReadLine();

            while (!CheckCorrect(strPar, out intPar))
            {
                Console.Write("Количество животных  введено некорртно, повторите ввод еще раз :");
                strPar = Console.ReadLine();
            }

            anketa.countPets = intPar;
            
        }
        anketa.PetsName = GetPetsName(anketa.countPets);

        anketa.CountColors = 0;
        Console.Write("{0}, Введите количество любимых цветов: ", anketa.name);
        strPar = Console.ReadLine();
        while (!CheckCorrect(strPar, out intPar))
        {
            Console.Write("Количкство введено некорртно, повторите ввод еще раз :");
            strPar = Console.ReadLine();
        }
        anketa.CountColors = intPar;
        anketa.favoritColors = GetFavoritColors(anketa.CountColors);
            
        return anketa;
    }

    static void ShowAnketa((string name, string lastName, int age, bool hasPets, int countPets, int CountColors, string[] PetsName, string[] favoritColors) user)
    {
        Console.WriteLine("Ваше имя и фамилия {0} {1}", user.name, user.lastName );
        Console.WriteLine("Ваш возраст: {0}", user.age);
        if (user.hasPets)
        {

            ShowPets(user.name, user.PetsName);
        }
        ShowColors(user.name, user.favoritColors);
    }
       
      
}