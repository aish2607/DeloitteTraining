using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpApplication
{
    internal class Movie
    {
        public void CreateMovie()
        {
        //how to create file?
        //FileStream fileStreamObj = new FileStream(@"C:\Users\daaishwarya\Desktop\Dotnet\CsharpApplication\CsharpApplication\movie.txt",FileMode.Create,FileAccess.Write);
        FileStream fileStreamObj = new FileStream("C:\\Users\\daaishwarya\\Desktop\\Dotnet\\CsharpApplication\\CsharpApplication\\movie.txt",FileMode.Create,FileAccess.Write);
        //how to write file?
        StreamWriter writer= new StreamWriter(fileStreamObj);
        Console.WriteLine("Enter Movie id:");
        writer.WriteLine(Console.ReadLine());
        Console.WriteLine("Enter Movie Name:");
        writer.WriteLine(Console.ReadLine());
        Console.WriteLine("Enter Movie Desc:");
        writer.WriteLine(Console.ReadLine());
        Console.WriteLine("Enter Movie Language:");
        writer.WriteLine(Console.ReadLine());
        writer.Close();//close writing operation
        fileStreamObj.Close();//close file operation
        Console.WriteLine("File operation  created");
        }
        //reading a file
        public void SelectMovie()
        {
            FileStream fileStream = new FileStream(@"C:\Users\daaishwarya\Desktop\Dotnet\CsharpApplication\CsharpApplication\movie.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader= new StreamReader(fileStream);
            //Console.WriteLine (reader.ReadLine());
            //Console.WriteLine( reader.ReadLine());  //for 4 lines of file 
            //Console.WriteLine(reader.ReadLine());
            //Console.WriteLine(reader.ReadLine());
            //fileStream.Close();
            //decalring Array -fixed and dynamic array
            //string[] myValues = new string[5];
            //myValues[0] = "A";
            //myValues[1] = "B";
            //myValues[2] = "C";

            //for multiple lines create loops
            while(reader.Peek()> 0)
            {
                //Console.WriteLine(reader.ReadLine());
                string line= reader.ReadLine();
                string[] mystring = line.Split(':');// split the input using pattern as argument
                Console.WriteLine(mystring[1]);
                
            }
            
        }
    }
}
