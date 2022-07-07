using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Handson_Csharp
{
    internal class Network
    {
        public void createnetwork()
        {
            FileStream newObj = new FileStream(@"C:\Users\daaishwarya\Desktop\Dotnet\Handson_Csharp\networklog.txt",FileMode.Open,FileAccess.Read);
            StreamReader sw = new StreamReader(newObj);
            Console.WriteLine("Id\t"  +  "Source\t\t" + "Destination\t\t" + "Date\t\t" +  "Status\t"  +  "Network" );
            string[] Arr = new string[4];
            while (sw.Peek() > 0)
            {
                string temp = sw.ReadLine();
                if (temp.StartsWith("Id"))
                {
                    Arr = temp.Split(':');
                    Console.Write(Arr[1] + "\t");
                }
                else if (temp.StartsWith("Source"))
                {
                    Arr = temp.Split(':');
                    Console.Write(Arr[1] + "\t");
                }
                else if (temp.StartsWith("Destination"))
                {
                    Arr = temp.Split(':');
                    Console.Write(Arr[1] + "\t");
                }
                else if (temp.StartsWith("Date"))
                {
                    Arr = temp.Split(':');
                    Console.Write(Arr[1] + ":" + Arr[2] + ":" + Arr[3] + "\t");
                }
                else if (temp.StartsWith("Status"))
                {
                    Arr = temp.Split(':');
                    Console.Write(Arr[1] + "\t");
                }
                else if (temp.StartsWith("Network"))
                {
                    Arr = temp.Split(':');
                    Console.WriteLine(Arr[1] + "\t");
                }
            }
                sw.Close();
        }
    }
}
