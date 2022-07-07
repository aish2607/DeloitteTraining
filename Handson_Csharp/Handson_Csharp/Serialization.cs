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
    public class weatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }

    }
    public class Employee
    {
        public int Id = 1;
        public String name = "John Smith";
        public string subject = "Physics";
    }
    
    internal class Serialization
    {
        public void JsonSerialize()
        {
            var weatherForecast = new weatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };
            //weatherForecast obj = new weatherForecast();
            //obj.Date = DateTime.Now;
            //obj.TemperatureCelsius = 20;
            //obj.Summary = "cool";

            //how to serialize from object to json
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            //how to Deserialize from json to object
            var obj = JsonSerializer.Deserialize<weatherForecast>(jsonString);
            Console.WriteLine(obj.Date);
            Console.WriteLine(obj.TemperatureCelsius);
            Console.WriteLine(obj.Summary);

        }
        public void XmlSerialize()
        {
            
            Employee bs=new Employee();
           
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\daaishwarya\Desktop\Dotnet\Handson_Csharp\serialization.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close(); 
        }
        //whenever its serialise pass writer object and deserialize pass reader object only
        public void XmlDeserialize()
        {
            Employee bs = new Employee();
            
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            StreamReader reader = new StreamReader(@"C:\Users\daaishwarya\Desktop\Dotnet\Handson_Csharp\serialization.xml");
            bs=(Employee)xs.Deserialize(reader);
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id:"+bs.Id);
            Console.WriteLine("Name:"+bs.name);
            Console.WriteLine("Subject" + bs.subject);

            reader.Close();

        }
    }
}
