using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class MyList
{
    public string LastName { get; set; }
    public string Name { get; set; }

    public static void sotrMyList(List<MyList> listSotr, int typeSotr)
    {
        if (typeSotr == 1)
        {
          
            listSotr.Sort(delegate (MyList x, MyList y)
            { 
                if (x.LastName == null && y.LastName == null) return 0;
                else if (x.LastName == null) return -1;
                else if (y.LastName == null) return 1;
                else return x.LastName.CompareTo(y.LastName);
            });
        }
        else
        {
            listSotr.Sort(delegate (MyList x, MyList y)
            {
                if (x.LastName == null && y.LastName == null) return 0;
                else if (x.LastName == null) return 1;
                else if (y.LastName == null) return -1;
                else return y.LastName.CompareTo(x.LastName);
            });
        }

        foreach (MyList  ls in listSotr)
        {
            Console.WriteLine(" {0} {1} ", ls.LastName,ls.Name);
        }
    }
}

