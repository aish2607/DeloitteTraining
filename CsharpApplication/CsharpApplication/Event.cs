using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpApplication
{
    public class Event
    {
        public int EventId;
        public int CreateEvent()
        {
            Console.WriteLine("Event Created!");
            return 10;
        }
        public void SelectEvent()
        {
            Console.WriteLine("Events selected!");

        }
      
    }
}
