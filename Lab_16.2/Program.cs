using System;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Lab_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsontext = "";
            using (StreamReader sr = new StreamReader("C:/tmp/Lab_16.json"))
            {
                jsontext = sr.ReadToEnd();
            }

            Product[] products = JsonSerializer.Deserialize<Product[]>(jsontext);

            Product maxProduct = products[0];
            foreach (Product p in products)
            {
                if (p.Cost > maxProduct.Cost) maxProduct = p;
            }
            if (maxProduct != null)
                Console.WriteLine("MaxPrice:{0} {1:f2}", maxProduct.Name, maxProduct.Cost);
            Console.ReadKey();
        }

        class Product
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public double Cost { get; set; }
        }
    }
}