using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Immutable;

class Program
{
    delegate int NumSort();

    static void Main(string[] args)
    {
        int parsort ;
       
        var s1 = new MyList { LastName = "Петров", Name = "Иван" };
        var s2 = new MyList { LastName = "Сидоров", Name = "Николай" };
        var s3 = new MyList { LastName = "Иванов", Name = "Константин" };
        var s4 = new MyList { LastName = "Романов", Name = "Петр" };
        var s5 = new MyList { LastName = "Белкина", Name = "Вера" };

        List<MyList> myLists = new List<MyList>();


        myLists.Add(s1);
        myLists.Add(s2);
        myLists.Add(s3);
        myLists.Add(s4);
        myLists.Add(s5);


        NumSort numSort = GetNumBerForSort.GetNumberSort;
        parsort = numSort.Invoke();

        MyList.sotrMyList(myLists, parsort);

    }

}