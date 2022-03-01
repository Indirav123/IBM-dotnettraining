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
            double d = 6.187;
            Console.WriteLine(d);
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
            int e,f;
            Console.WriteLine("Enter values");
            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());
            e = e * f;
            f = e / f;
            e = e / f;
            Console.WriteLine("after swap e="+e+"b="+f);
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
