using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Handson_Csharp
{
    public class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }    
    }
    internal class HandsOn
    {
        public void XmlSerialize()
        {
            person obj= new person();
            Console.WriteLine("Enter Name");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            obj.Age= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter City");
            obj.City= Console.ReadLine();   
            XmlSerializer x= new XmlSerializer(typeof(person));
            TextWriter txt = new StreamWriter(@"C:\Users\daaishwarya\Desktop\Dotnet\Handson_Csharp\person.xml");
            x.Serialize(txt,obj);
            txt.Close();
        }
        public void XmlDeserialize()
        {
            person obj = new person();
            XmlSerializer x = new XmlSerializer(typeof(person));
            StreamReader reader = new StreamReader(@"C:\Users\daaishwarya\Desktop\Dotnet\Handson_Csharp\person.xml");
            obj = (person)x.Deserialize(reader);
            Console.WriteLine("Person details");
            Console.WriteLine("Name:"+obj.Name);
            Console.WriteLine("Age:"+obj.Age); 
            Console.WriteLine("City:"+obj.City);
            reader.Close(); 
        }
        public void JsonSerialize()
        {
            person abc= new person();
            Console.WriteLine("Enter Name");
            abc.Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            abc.Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter City");
            abc.City = Console.ReadLine();
           //StreamWriter txtwriter = new StreamWriter(@"C:\Users\daaishwarya\Desktop\Dotnet\Handson_Csharp\person.json");
           //how to serialize from object to json
            string jsonString = JsonSerializer.Serialize(abc);
            Console.WriteLine(jsonString);
            //how to Deserialize from json to object
            var ob= JsonSerializer.Deserialize<person>(jsonString);
            Console.WriteLine(ob.Name);
            Console.WriteLine(ob.Age);
            Console.WriteLine(ob.City);

            //txtwriter.Close();
        }
    }
}
