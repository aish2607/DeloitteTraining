using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_HandsOn
{
    public class positive
    {
        public void Numbers()
        {
            int[] Values = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = from d in Values  //d is tablename
                         where d!= 0 && d>0
                         select d;
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
        }
        public void frequency()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.WriteLine("The numbers in the array are: \n");
            Console.Write("5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 \n");
            var arr2 = from d in arr1
                       group d by d into x
                       select x;
            Console.WriteLine("The number and frequency are:");
            foreach (var item in arr2)
            {
                
                Console.WriteLine("Number {0} appears {1} times", item.Key, item.Count());
            }
                       
        }
        public void freq_char()
        {
            String input = Console.ReadLine();

            var result = from d in input
                         group d by d into x
                         select x;
            Console.WriteLine("The frequency of the characters are:");

            foreach (var item in result)
            {

                Console.WriteLine("Character {0} :{1} times", item.Key, item.Count());
            }
        }
        public void city_names()
        {
            string[] cities = {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            
            Console.WriteLine("Input starting character for the string :");
            char start_char = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Input starting character for the string :");
            char end_char = Convert.ToChar(Console.ReadLine());
            var result = from c in cities
                         where c.StartsWith(""+start_char) && c.EndsWith(""+end_char) 
                         select c;
            foreach(var item in result)
            {
                Console.WriteLine("The city starting with {0} and ends with {1} is :{2}",start_char,end_char, item);
            }
        }
        public void Nth_record()
        {
            int[] arr1 = new int[] {5,7,13,24,6,9,8,7};
            Console.WriteLine("The members of the list are :");
            Console.WriteLine("5,7,13,24,6,9,8,7");
            Console.WriteLine("How many records you want to display");
            int input = Convert.ToInt32(Console.ReadLine());

            var result = (from n in arr1
                          orderby n descending
                          select n).Take(input);
            Console.WriteLine("The top 3 records are:");
            foreach(var item in result)
            {
                Console.Write(item+"\t");
            }
        }
       
    }

    public class Students
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }

        public void max_grade()
        {

            List<Students> stulist = new List<Students>() {
            new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 },
            new Students { StuId = 2, StuName = "Alex", GrPoint = 458 },
            new Students { StuId = 3, StuName = "Harris", GrPoint = 900 },
            new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 },
            new Students { StuId = 5, StuName = "Smith", GrPoint = 458 },
            new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 },
            new Students { StuId = 7, StuName = "David", GrPoint = 750 },
            new Students { StuId = 8, StuName = "Harry", GrPoint = 700 },
            new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 },
            new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 },
        };
            Console.WriteLine("Which maximum grade point do you want to find:");

            int input = Convert.ToInt32(Console.ReadLine());
            var result = (from n in stulist
                          group n by n.GrPoint into g
                          orderby g.Key descending
                          select new
                          {
                              record = g.ToList()
                          }).ToList();
            var temp = result[input - 1].record;
            foreach (var item in temp)
            {
                Console.WriteLine("Id:{0}, Name:{1}, Achieved grade point:{2} ", item.StuId, item.StuName, item.GrPoint);
            }
            Console.Read();
        }
    }
    public class Person
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public void Ending_with()
        {

            var people = new List<Person>();

            people.Add(new Person { First_Name = "Bill", Last_Name = "Smith", Age = 41 });
            people.Add(new Person { First_Name = "Sarah", Last_Name = "Jones", Age = 22 });
            people.Add(new Person { First_Name = "Stacy", Last_Name = "Baker", Age = 21 });
            people.Add(new Person{ First_Name = "Vivianne", Last_Name = "Dexter", Age = 19 });
            people.Add(new Person{ First_Name = "Bob", Last_Name = "Smith", Age = 49 });
            people.Add(new Person{ First_Name = "Brett", Last_Name = "Baker", Age = 51 });
            people.Add(new Person { First_Name = "Mark", Last_Name = "Parker", Age = 19 });
            people.Add(new Person{ First_Name = "Alice", Last_Name = "Thompson", Age = 18 });
            people.Add(new Person { First_Name = "Evelyn", Last_Name = "Thompson", Age = 58 });
            people.Add(new Person { First_Name = "Mort", Last_Name = "Martin", Age = 58 });
            people.Add(new Person{ First_Name = "Eugene", Last_Name = "DeLauter", Age = 84 });
            people.Add(new Person{ First_Name = "Gail", Last_Name = "Dawson", Age = 19 });


            var result = from d in people
                         where d.Last_Name.StartsWith("D")
                         
                         select d;
            int i = 0;
            foreach(var item in result)
            {
                i++;
                Console.WriteLine(item.Last_Name);
                
            }
            Console.WriteLine(i);
            Console.Read();
        }
        public void older()
        {
            var people = new List<Person>();

            people.Add(new Person { First_Name = "Bill", Last_Name = "Smith", Age = 41 });
            people.Add(new Person { First_Name = "Sarah", Last_Name = "Jones", Age = 22 });
            people.Add(new Person { First_Name = "Stacy", Last_Name = "Baker", Age = 21 });
            people.Add(new Person { First_Name = "Vivianne", Last_Name = "Dexter", Age = 19 });
            people.Add(new Person { First_Name = "Bob", Last_Name = "Smith", Age = 49 });
            people.Add(new Person { First_Name = "Brett", Last_Name = "Baker", Age = 51 });
            people.Add(new Person { First_Name = "Mark", Last_Name = "Parker", Age = 19 });
            people.Add(new Person { First_Name = "Alice", Last_Name = "Thompson", Age = 18 });
            people.Add(new Person { First_Name = "Evelyn", Last_Name = "Thompson", Age = 58 });
            people.Add(new Person { First_Name = "Mort", Last_Name = "Martin", Age = 58 });
            people.Add(new Person { First_Name = "Eugene", Last_Name = "DeLauter", Age = 84 });
            people.Add(new Person { First_Name = "Gail", Last_Name = "Dawson", Age = 19 });

            var result = from d in people
                         orderby d.First_Name ascending
                         where d.Age > 40
                         select d;
            foreach(var item in result)
            {
                Console.WriteLine(item.First_Name);
            }
        }
    }
    public class fruits
    {
        public void num5()
        {

            List<string> fruits = new List<string>() { "Lemon", "Apple",
                "Orange", "Lime", "Watermelon", "Loganberry" };
            var result = from d in fruits
                         where d.StartsWith("L")
                         select d;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
    public class multiples
    {
        List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

        public void mixed_num()
        {
            var result = from d in mixedNumbers
                         where d % 4 == 0 || d % 6 == 0
                         select d;
            Console.Write("All the numbers which are multiple of 4 or 6 are : ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }

    internal class positive_nos
    {
        
    }
}
