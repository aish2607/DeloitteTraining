using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//exceptional handling to catch run time errors
namespace Handson_Csharp
{
    internal class GenericsDemo
    {
        public void ShowReport <T>(T value)
        {
            Console.WriteLine(value);
        }
        public static void Generic()
        {
            try
            {
                //business logic code or source code
                string[] v = new string[3];
                v[0] = "Abc";
                v[1] = "asn";
                v[2] = "aja"; 
                v[3] = "xyz";
                //assigning 4 values error
            }
            catch(Exception ex)
            {
                //log exception
                Console.WriteLine("Error"); // will throw an error cause out of bound array used
            }
        }


        //GARBAGE COLLECTION -In .net, objects will be removed automatically from memory by default
        // fileStreamObj.Dispose() -- releases all objects from the memory

        using(FileStream fs= new FileStream("", FileMode.Open));
        

        //public void ShowGenderReport(string gender)
        //{
        //    Console.WriteLine(gender);
        //}
        //public void ShowAgeReport(int age)
        //{
        //    Console.WriteLine(age);
        //}
        //public void ShowSalaryReport(double salary)
        //{
        //    Console.WriteLine(salary);
        //}
    }
}
