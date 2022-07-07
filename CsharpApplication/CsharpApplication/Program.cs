using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a;
            int b;
            int c;
            Console.WriteLine("Enter value of A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B:");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            //how to print 
            Console.Write("Output:");
            Console.Write(c);
            Console.Read(); //to read keyboard input*/
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);

            //}
            //Event eventObj=new Event();// to create object/instance
            //eventObj.CreateEvent();
            //Console.WriteLine("output");
            //eventObj.SelectEvent();
            //Console.Read();
            Movie movieObj = new Movie();
            movieObj.CreateMovie();
            
            movieObj.SelectMovie();
            Console.Read();

        }

    }
}
