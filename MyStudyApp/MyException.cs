using System;
using System.Collections.Generic;
using System.Text;

public class MyException : Exception
{
    public MyException()
    { }

    public MyException(string message)
        : base(message)
    { }

        
}

