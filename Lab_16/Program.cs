using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = "{\"FirstName\":\"Tom\",\"lastName\":\"Jackson\",\"gender\":\"male\",\"age\":29,\"online\":true,\"hobby\":[\"football\",\"reading\",\"swimming\"]}";
            Person person = JsonSerializer.Deserialize<Person>(jsonString);
            Person person1 = new Person()
            {
                FirstName = "V",
                lastName = "B",
                gender = "male",
                online = false,
                hobby = new string[] { "swimming" }
            };
            string jsonString1 = JsonSerializer.Serialize(person1);
            Console.WriteLine(jsonString1);
            Console.ReadKey();
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public bool online { get; set; }
        public string[] hobby { get; set; }
    }
}

