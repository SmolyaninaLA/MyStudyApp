using System;

class MainClass
{
  

    public static void Main(string[] args)
    {

        (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

        for (int k = 0; k < 3; k++)
        {
            Console.WriteLine("Ведите имя  :");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введитr фамилию :");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введитr логин:");
            User.Login = Console.ReadLine();

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var res = Console.ReadLine().ToUpper();



            User.favcolors = new string[3];

            Console.WriteLine("Введите 3 любимых цвета ");
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }

            Console.WriteLine("Введитr возраст  :");
            User.Age = double.Parse(Console.ReadLine());

            User.LoginLength = User.Login.Length;

            Console.WriteLine("Вас зовут {0} {1} , вам {2} лет ", User.Name, User.LastName, User.Age);
            Console.WriteLine("Ваш логин  {0} , длина логина  = {1}", User.Login, User.LoginLength);

            User.HasPet = false;

            if (res == "ДА")
            {
                User.HasPet = true;
            }


            if (User.HasPet)
            {
                Console.WriteLine(" У вас есть домашний любимец");
            }

            for (int i = 0; i < User.favcolors.Length; i++)
            {
                Console.Write( User.favcolors[i] + " ");
            }


        }

        Console.ReadKey();
    }
}
