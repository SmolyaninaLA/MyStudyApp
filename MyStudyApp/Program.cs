using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        // получим папку

        Console.WriteLine("Введите путь ");
        string pathDir = Console.ReadLine();


        if (!Directory.Exists(pathDir))
        {
            Console.WriteLine("Нет указанго пути");
        }
        else
        {
            string[] subdir = Directory.GetDirectories(pathDir);
            string[] fl = Directory.GetFiles(pathDir);

            DateTime dt,curdt;
           
            TimeSpan diff;

            foreach (string sd in subdir)
            {
               dt = Directory.GetLastWriteTime(sd);
                try
                {
                    curdt = DateTime.Now;
                    diff = curdt - dt;
                     

                    if (diff.TotalMinutes >  30.0)
                    {
                 
                       Directory.Delete(sd, true);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Произошла ошибка : {0}", ex.Message);
                }


            }

            foreach (string fi in fl )
            {
                var filefordel = new FileInfo(fi);
                dt = filefordel.LastWriteTime;

                try
                {
                    curdt = DateTime.Now;
                    diff = curdt - dt;


                    if (diff.TotalMinutes > 30.0)
                    {
                        filefordel.Delete();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Произошла ошибка обработки файлов: {0}", ex.Message);
                }


            }
        }
    }


}