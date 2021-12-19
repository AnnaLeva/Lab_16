using System;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Lab_16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            for (int i = 0; i < 5; i++)
            {
                products[i] = new Product();
                Console.WriteLine("Code:");
                products[i].Code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name:");
                products[i].Name = Console.ReadLine();
                Console.WriteLine("Price:");
                products[i].Cost = Convert.ToDouble(Console.ReadLine());
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            };
            string outJs = JsonSerializer.Serialize(products, options);
            Console.WriteLine(outJs);

            using (StreamWriter sw = new StreamWriter("C:/tmp/Lab_16.json"))
            {
                sw.WriteLine(outJs);
            }
            Console.ReadKey();
        }
    }

    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}