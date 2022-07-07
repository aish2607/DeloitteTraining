using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson_Csharp
{
    internal class arrayDemo
    {
        public static void GetTotalTickets() //static allows ot access the class name directly

        {
            arrayDemo.GetTotalTickets(); 
            //what is jagged array? Easy to customize
            string[][] counter= new string[3][];    //3 counters or columns and n rows in each column
            counter[0] = new string[3];  //3 rows in 1st column
            counter[1] = new string[2]; //2  rows
            counter[2] = new string[4]; // 4 rows

            //hard coded
            //counter[0][0] = "P1";
            //counter[0][1] = "P2";
            //counter[0][2] = "P3";

            //counter[1][0] = "P6";
            //counter[1][1] = "P5";

            //counter[2][0] = "P7";
            //counter[2][1] = "P5";
            //counter[2][2] = "P3";
            //counter[2][3] = "P8";

            for(int i=0;i< counter.Length;i++)
            {
                for(int j=0; j < counter[i].Length; j++)
                {

                }
            }
            
        }
    }
}
