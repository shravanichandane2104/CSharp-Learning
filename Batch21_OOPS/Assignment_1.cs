using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Batch21_OOPS
{
    internal class Assignment_1
    {
        static void Main()
        {
            //add correct data type
            int myNum = 9;
            float myFloatNum = 8.99f;
            char myLetter = 'A';
            bool myBool = false;
            string myText = "hello world";
            Console.WriteLine("Data Types:-" );
            Console.WriteLine("myNum    :" + myNum);
            Console.WriteLine("myFloatNum :" + myFloatNum);
            Console.WriteLine("myLetter :" + myLetter);
            Console.WriteLine("myBool    :" + myBool);
            Console.WriteLine("myText  :" + myText);


            ///READ 2 INTEGER NUMBER AND DISPLAY SUM 
            int a = 10;
            int b = 20;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Addition is : " + (a + b));

            //Read 2 flaoting points number and display subtraction 
            float c = 10.5f;
            float d = 5.2f;
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("Subtraction is : " + (c - d));

            //Read 2 integer and print product of them 
             int e = 10;
            int f = 20;
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = " + f);
           Console.WriteLine("Product is : " + (e * f));

            //read 2 integer number and display sum division 
            int g = 20;
            int h = 5;
            Console.WriteLine("g = " + g);
            Console.WriteLine("h = " + h);
            Console.WriteLine("Division is : " + (g / h));


        }
    }
}

