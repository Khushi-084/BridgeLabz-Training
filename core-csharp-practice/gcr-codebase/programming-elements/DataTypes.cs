using System;

class DataTypes
{
    public static void Main(string[] args)
    {
		//Primitive Data Types
        // byte (8-bit)
        byte a = 2;
        Console.WriteLine("The byte number: "+ a);

        // short (16-bit)
        short b = 120;
        Console.WriteLine("The short number: " + b);

        // int (32-bit)
        int c = 582;
        Console.WriteLine("The integer :" + c);

        // long (64-bit)
        long d = 435000L;
        Console.WriteLine("The long number: " + d);

        // float (32-bit floating point)
        float e = 10.06F;
        Console.WriteLine("The float number: " + e);

        // double (64-bit floating point)
        double f = 8564.8764;
        Console.WriteLine("The double number : " + f);

        // char (16-bit )
        char ch = 'A';
        Console.WriteLine("The char value: " + ch);

        // bool (true/false)
        bool isValid = true;
        Console.WriteLine("The boolean value: " + isValid);



         //TYPE CONVERSION
        //Implicit conversion(smaller to larger)
        //1
        int val=78;
        double di=val;
        Console.WriteLine("The integer number converted to double is: " + di);

       //2
        byte b=5;
        int t=b;
        Console.WriteLine("The byte number coverted to int is: " + t);

        //Explicit Type conversion (larger to smaller)
        //1
        double dou=7890.3456;
        int din=(int)dou;

        //using Convert.To
        //2
        int r=Convert.ToInt32(13.57);
        bool p=Convert.ToBoolean("true");
        char c=Convert.ToChar("T");
    }
}


