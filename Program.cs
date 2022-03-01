using System;


namespace Myfirstconsolecsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c#");
            Console.WriteLine("IBM Training");
            Console.WriteLine("hello");
            string name="Peter";
            Console.WriteLine(name);
            string address = "Hyderabad";
            //{} string interpolation
            Console.WriteLine("my name is{0} and I am from {1}", name, address);
            int val = 9 + 5;
            Console.WriteLine("val:" + val);
            double d = 6.187;
            Char s = 'D';
            bool t = true;
            Console.WriteLine("Double:"+d);
            Console.WriteLine("Char:" + s);
            Console.WriteLine("Boolean:" + t);
            //Typecasting 
            double one = 8.9;
            int two=(int)one;
            Console.WriteLine("Explicit typecast:" + one);
            Console.WriteLine(two);
            //switch case
            int colorcode;
            Console.WriteLine("Enter colorcode");
            colorcode = int.Parse(Console.ReadLine());
            switch(colorcode)
            {
                case 0: Console.WriteLine("red");
                    break; 
                case 1: Console.WriteLine("yellow");
                    break;
                default: Console.WriteLine("Invalid");
                    break;
            }
            //task 1:greatest of three numbers
            int a, b,c;
            Console.WriteLine("Enter the values of a,b,c");
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            if (a > b&&a>c)
                Console.WriteLine("a is greater");
            if (b > a && b > c)
                Console.WriteLine("b is greater");
            if(c > a&& c>b)
                Console.WriteLine("c is greater");
            //task 2:swaping of 2 numbers withiut third variable
            int e,f;
            Console.WriteLine("Enter values");
            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
            e = e * f;
            f = e / f;
            e = e / f;
            Console.WriteLine("after swap e="+e+"b="+f);
            //task 3:employee details
            string empid,empname;
            int age, salary;
            Console.WriteLine("Enter empid,empname,age,salary");
            empid = Console.ReadLine();
            empname=Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("The details of the employee are empid="+empid+ "empname="+empname+ "age="+age+ "salary="+salary);
            
            Console.ReadLine();

        }
    }
}
