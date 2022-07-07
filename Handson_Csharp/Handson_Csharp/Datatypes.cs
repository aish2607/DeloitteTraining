using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Collections;
namespace Handson_Csharp
{
    internal class Datatypes
    {
        public static void nongeneric()
        {
            //hashtable
            Hashtable hashtable = new Hashtable();
            hashtable[101] = "Passed";
            hashtable[102] = "Passed";
            hashtable[103] = "Failed";
            //dictionary
            Dictionary<int,string> student= new Dictionary<int, string>();
            student[101] = "Passed";
            student[102] = "Failed";
            student[103] = "Passed";
            student[104] = "Passed";
            student[105] = "Failed";
            student[105] = "Passed";

            foreach(var item in student)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                //how to get value by passing key?
                Console.WriteLine(student[item.Key]);

            }
            //generic instead of typecasting
            List<int> list = new List<int>();
            list.Add(10);
            int myValue = list[0];

            //stack LIFO
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("Raj");
            stack.Push(5000);

            //queue FIFO
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("Raj");
            queue.Enqueue(5000);

        }
        
       


        





    }

}
